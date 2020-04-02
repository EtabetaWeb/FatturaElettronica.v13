Imports System.IO
Imports System.Xml.Serialization
Imports FatturaEL.v13

Public Class GeneraXML

    Private Function genera_xml(percorso As String, nome_file As String) As Boolean
        Dim esito As Boolean = False
        Try
            Dim nodoPrincipale As New FatturaElettronica()
            Dim overviewHeader As New FatturaElettronicaHeader()
            Dim datiTrasmissione As New DatiTrasmissione()
            Dim idTrasmittente_111 As New IdTrasmittente()
            idTrasmittente_111.IdPaese = "IT"
            idTrasmittente_111.IdCodice = ""
            datiTrasmissione.IdTrasmittente = idTrasmittente_111
            datiTrasmissione.ProgressivoInvio = ""
            datiTrasmissione.FormatoTrasmissione = "FPA12"
            datiTrasmissione.CodiceDestinatario = "0000000"
            Dim contattiTrasmittente_115 As New ContattiTrasmittente()
            contattiTrasmittente_115.Telefono = ""
            contattiTrasmittente_115.Email = ""
            datiTrasmissione.ContattiTrasmittente = contattiTrasmittente_115
            datiTrasmissione.PECDestinatario = ""
            overviewHeader.DatiTrasmissione = datiTrasmissione
            Dim cedentePrestatore As New CedentePrestatore()
            Dim datiAnagrafici_121 As New DatiAnagrafici()
            Dim idFiscaleIVA_121 As New IdFiscaleIVA()
            idFiscaleIVA_121.IdPaese = ""
            idFiscaleIVA_121.IdCodice = ""
            datiAnagrafici_121.IdFiscaleIVA = idFiscaleIVA_121
            datiAnagrafici_121.CodiceFiscale = ""
            Dim anagrafica_121 As New Anagrafica()
            anagrafica_121.Denominazione = ""
            anagrafica_121.Nome = ""
            anagrafica_121.Cognome = ""
            anagrafica_121.Titolo = ""
            anagrafica_121.CodEORI = ""
            datiAnagrafici_121.Anagrafica = anagrafica_121
            datiAnagrafici_121.AlboProfessionale = ""
            datiAnagrafici_121.ProvinciaAlbo = ""
            datiAnagrafici_121.NumeroIscrizioneAlbo = ""
            datiAnagrafici_121.DataIscrizioneAlbo = ""
            datiAnagrafici_121.RegimeFiscale = ""
            cedentePrestatore.DatiAnagrafici = datiAnagrafici_121
            Dim sede_122 As New Sede()
            sede_122.Indirizzo = ""
            sede_122.NumeroCivico = ""
            sede_122.CAP = ""
            sede_122.Comune = ""
            sede_122.Provincia = ""
            sede_122.Nazione = ""
            cedentePrestatore.Sede = sede_122
            Dim stabileOrganizzazione_123 As New StabileOrganizzazione
            stabileOrganizzazione_123.Indirizzo = ""
            stabileOrganizzazione_123.NumeroCivico = ""
            stabileOrganizzazione_123.CAP = ""
            stabileOrganizzazione_123.Comune = ""
            stabileOrganizzazione_123.Provincia = ""
            stabileOrganizzazione_123.Nazione = ""
            cedentePrestatore.StabileOrganizzazione = stabileOrganizzazione_123
            Dim iscrizioneREA_124 As New IscrizioneREA
            iscrizioneREA_124.Ufficio = ""
            iscrizioneREA_124.NumeroREA = ""
            iscrizioneREA_124.CapitaleSociale = ""
            iscrizioneREA_124.SocioUnico = ""
            iscrizioneREA_124.StatoLiquidazione = ""
            cedentePrestatore.IscrizioneREA = iscrizioneREA_124
            Dim contatti_125 As New Contatti
            contatti_125.Telefono = ""
            contatti_125.Fax = ""
            contatti_125.Email = ""
            cedentePrestatore.Contatti = contatti_125
            cedentePrestatore.RiferimentoAmministrazione = ""
            overviewHeader.CedentePrestatore = cedentePrestatore
            Dim rappresentanteFiscale As New RappresentanteFiscale
            Dim datiAnagrafici_131 As New DatiAnagrafici
            Dim idFiscaleIVA_131 As New IdFiscaleIVA
            idFiscaleIVA_131.IdPaese = ""
            idFiscaleIVA_131.IdPaese = ""
            datiAnagrafici_131.IdFiscaleIVA = idFiscaleIVA_131
            datiAnagrafici_131.CodiceFiscale = ""
            Dim anagrafica_131 As New Anagrafica
            anagrafica_131.Denominazione = ""
            anagrafica_131.Nome = ""
            anagrafica_131.Cognome = ""
            anagrafica_131.Titolo = ""
            anagrafica_131.CodEORI = ""
            datiAnagrafici_131.Anagrafica = anagrafica_131
            rappresentanteFiscale.DatiAnagrafici = datiAnagrafici_131
            overviewHeader.RappresentanteFiscale = rappresentanteFiscale
            Dim cessionarioCommittente As New CessionarioCommittente
            Dim datiAnagrafici_141 As New DatiAnagrafici
            Dim idFiscaleIVA_141 As New IdFiscaleIVA
            idFiscaleIVA_141.IdPaese = ""
            idFiscaleIVA_141.IdCodice = ""
            datiAnagrafici_141.IdFiscaleIVA = idFiscaleIVA_141
            datiAnagrafici_141.CodiceFiscale = ""
            Dim anagrafica_141 As New Anagrafica
            anagrafica_141.Denominazione = ""
            anagrafica_141.Nome = ""
            anagrafica_141.Cognome = ""
            anagrafica_141.Titolo = ""
            anagrafica_141.CodEORI = ""
            datiAnagrafici_141.Anagrafica = anagrafica_141
            cessionarioCommittente.DatiAnagrafici = datiAnagrafici_141
            Dim sede_142 As New Sede
            sede_142.Indirizzo = ""
            sede_142.NumeroCivico = ""
            sede_142.CAP = ""
            sede_142.Comune = ""
            sede_142.Provincia = ""
            sede_142.Nazione = ""
            cessionarioCommittente.Sede = sede_142
            Dim stabileOrganiccazione_143 As New StabileOrganizzazione
            stabileOrganiccazione_143.Indirizzo = ""
            stabileOrganiccazione_143.NumeroCivico = ""
            stabileOrganiccazione_143.CAP = ""
            stabileOrganiccazione_143.Comune = ""
            stabileOrganiccazione_143.Provincia = ""
            stabileOrganiccazione_143.Nazione = ""
            cessionarioCommittente.StabileOrganizzazione = stabileOrganiccazione_143
            Dim rappresentanteFiscale_144 As New RappresentanteFiscale
            Dim datiAnagrafici_144 As New DatiAnagrafici
            Dim idFiscaleIVA_144 As New IdFiscaleIVA
            idFiscaleIVA_144.IdPaese = ""
            idFiscaleIVA_144.IdCodice = ""
            datiAnagrafici_144.IdFiscaleIVA = idFiscaleIVA_144
            Dim anagrafica_144 As New Anagrafica
            anagrafica_144.Denominazione = ""
            anagrafica_144.Nome = ""
            anagrafica_144.Cognome = ""
            datiAnagrafici_144.Anagrafica = anagrafica_144
            rappresentanteFiscale_144.DatiAnagrafici = datiAnagrafici_144
            overviewHeader.CessionarioCommittente = cessionarioCommittente
            Dim terzoIntermediarioOSoggettoEmittente As New TerzoIntermediarioOSoggettoEmittente
            Dim datiAnagrafici_151 As New DatiAnagrafici
            Dim idFiscaleIVA_151 As New IdFiscaleIVA
            idFiscaleIVA_151.IdPaese = ""
            idFiscaleIVA_151.IdCodice = ""
            datiAnagrafici_151.IdFiscaleIVA = idFiscaleIVA_151
            datiAnagrafici_151.CodiceFiscale = ""
            datiAnagrafici_151.CodiceFiscale = ""
            Dim anagrafica_151 As New Anagrafica
            anagrafica_151.Denominazione = ""
            anagrafica_151.Nome = ""
            anagrafica_151.Cognome = ""
            anagrafica_151.Titolo = ""
            anagrafica_151.CodEORI = ""
            datiAnagrafici_151.Anagrafica = anagrafica_151
            overviewHeader.TerzoIntermediarioOSoggettoEmittente = terzoIntermediarioOSoggettoEmittente
            overviewHeader.SoggettoEmittente = ""
            Dim overviewBody As New FatturaElettronicaBody()
            Dim datiGenerali As New DatiGenerali()
            Dim datiGeneraliDocumento As New DatiGeneraliDocumento
            datiGeneraliDocumento.TipoDocumento = ""
            datiGeneraliDocumento.Divisa = ""
            datiGeneraliDocumento.Data = ""
            datiGeneraliDocumento.Numero = ""
            Dim datiRitenuta As New DatiRitenuta
            datiRitenuta.TipoRitenuta = ""
            datiRitenuta.ImportoRitenuta = ""
            datiRitenuta.AliquotaRitenuta = ""
            datiRitenuta.CausalePagamento = ""
            datiGeneraliDocumento.DatiRitenuta = datiRitenuta
            Dim datiBollo As New DatiBollo
            datiBollo.BolloVirtuale = ""
            datiBollo.ImportoBollo = ""
            datiGeneraliDocumento.DatiBollo = datiBollo
            Dim datiCassaPrevidenziale As New DatiCassaPrevidenziale
            Dim datiCassaPrevidenzialeList As New List(Of DatiCassaPrevidenziale)
            datiCassaPrevidenziale.TipoCassa = ""
            datiCassaPrevidenziale.AlCassa = ""
            datiCassaPrevidenziale.ImportoContributoCassa = ""
            datiCassaPrevidenziale.ImponibileCassa = ""
            datiCassaPrevidenziale.AliquotaIVA = ""
            datiCassaPrevidenziale.Ritenuta = ""
            datiCassaPrevidenziale.Natura = ""
            datiCassaPrevidenziale.RiferimentoAmministrazione = ""
            datiCassaPrevidenzialeList.Add(datiCassaPrevidenziale)
            datiGeneraliDocumento.DatiCassaPrevidenziale = datiCassaPrevidenzialeList
            Dim scontoMaggiorazione As New ScontoMaggiorazione
            Dim scontoMaggiorazioneList As New List(Of ScontoMaggiorazione)
            scontoMaggiorazione.Tipo = ""
            scontoMaggiorazione.Percentuale = ""
            scontoMaggiorazione.Importo = ""
            scontoMaggiorazioneList.Add(scontoMaggiorazione)
            datiGeneraliDocumento.ScontoMaggiorazione = scontoMaggiorazioneList
            datiGeneraliDocumento.ImportoTotaleDocumento = ""
            datiGeneraliDocumento.Arrotondamento = ""
            datiGeneraliDocumento.Causale = ""
            datiGeneraliDocumento.Art73 = ""
            datiGenerali.DatiGeneraliDocumento = datiGeneraliDocumento
            Dim datiOrdineAcquisto As New DatiOrdineAcquisto
            Dim datiOrdineAcquistoList As New List(Of DatiOrdineAcquisto)
            datiOrdineAcquisto.RiferimentoNumeroLinea = ""
            datiOrdineAcquisto.IdDocumento = ""
            datiOrdineAcquisto.Data = ""
            datiOrdineAcquisto.NumItem = ""
            datiOrdineAcquisto.CodiceCommessaConvenzione = ""
            datiOrdineAcquisto.CodiceCUP = ""
            datiOrdineAcquisto.CodiceCIG = ""
            datiOrdineAcquistoList.Add(datiOrdineAcquisto)
            datiGenerali.DatiOrdineAcquisto = datiOrdineAcquistoList
            Dim datiContratto As New DatiContratto
            Dim datiContrattoList As New List(Of DatiContratto)
            datiContratto.RiferimentoNumeroLinea = ""
            datiContratto.IdDocumento = ""
            datiContratto.Data = ""
            datiContratto.NumItem = ""
            datiContratto.CodiceCommessaConvenzione = ""
            datiContratto.CodiceCUP = ""
            datiContratto.CodiceCIG = ""
            datiContrattoList.Add(datiContratto)
            datiGenerali.DatiContratto = datiContrattoList
            Dim datiConvenzione As New DatiConvenzione
            Dim datiConvenzioneList As New List(Of DatiConvenzione)
            datiConvenzione.RiferimentoNumeroLinea = ""
            datiConvenzione.IdDocumento = ""
            datiConvenzione.Data = ""
            datiConvenzione.NumItem = ""
            datiConvenzione.CodiceCommessaConvenzione = ""
            datiConvenzione.CodiceCUP = ""
            datiConvenzione.CodiceCIG = ""
            datiConvenzioneList.Add(datiConvenzione)
            datiGenerali.DatiConvenzione = datiConvenzioneList
            Dim datiRicezione As New DatiRicezione
            Dim datiRicezioneList As New List(Of DatiRicezione)
            datiRicezione.RiferimentoNumeroLinea = ""
            datiRicezione.IdDocumento = ""
            datiRicezione.Data = ""
            datiRicezione.NumItem = ""
            datiRicezione.CodiceCommessaConvenzione = ""
            datiRicezione.CodiceCUP = ""
            datiRicezione.CodiceCIG = ""
            datiRicezioneList.Add(datiRicezione)
            datiGenerali.DatiRicezione = datiRicezioneList
            Dim datiFattureCollegate As New DatiFattureCollegate
            Dim datiFattureCollegateList As New List(Of DatiFattureCollegate)
            datiFattureCollegate.RiferimentoNumeroLinea = ""
            datiFattureCollegate.IdDocumento = ""
            datiFattureCollegate.Data = ""
            datiFattureCollegate.NumItem = ""
            datiFattureCollegate.CodiceCommessaConvenzione = ""
            datiFattureCollegate.CodiceCUP = ""
            datiFattureCollegate.CodiceCIG = ""
            datiFattureCollegateList.Add(datiFattureCollegate)
            datiGenerali.DatiFattureCollegate = datiFattureCollegateList
            Dim datiSAL As New DatiSAL
            Dim datiSALList As New List(Of DatiSAL)
            datiSAL.RiferimentoFase = ""
            datiSALList.Add(datiSAL)
            datiGenerali.DatiSAL = datiSALList
            Dim datiDDT As New DatiDDT
            Dim datiDDTList As New List(Of DatiDDT)
            datiDDT.NumeroDDT = ""
            datiDDT.DataDDT = ""
            datiDDT.RiferimentoNumeroLinea = ""
            datiDDTList.Add(datiDDT)
            datiGenerali.DatiDDT = datiDDTList
            Dim datiTrasporto As New DatiTrasporto
            Dim datiAnagraficiVettore As New DatiAnagraficiVettore
            Dim idFiscaleIva As New IdFiscaleIVA
            idFiscaleIva.IdCodice = ""
            idFiscaleIva.IdPaese = ""
            datiAnagraficiVettore.IdFiscaleIVA = idFiscaleIva
            datiAnagraficiVettore.CodiceFiscale = ""
            Dim anagraficaVettore As New Anagrafica
            anagraficaVettore.Denominazione = ""
            anagraficaVettore.Nome = ""
            anagraficaVettore.Cognome = ""
            anagraficaVettore.Titolo = ""
            anagraficaVettore.CodEORI = ""
            datiAnagraficiVettore.Anagrafica = anagraficaVettore
            datiAnagraficiVettore.NumeroLicenzaGuida = ""
            datiTrasporto.MezzoTrasporto = ""
            datiTrasporto.CausaleTrasporto = ""
            datiTrasporto.NumeroColli = ""
            datiTrasporto.Descrizione = ""
            datiTrasporto.UnitaMisuraPeso = ""
            datiTrasporto.PesoLordo = ""
            datiTrasporto.PesoNetto = ""
            datiTrasporto.DataOraRitiro = ""
            datiTrasporto.DataInizioTrasporto = ""
            datiTrasporto.TipoResa = ""
            Dim indirizzoResa As New IndirizzoResa
            indirizzoResa.Indirizzo = ""
            indirizzoResa.NumeroCivico = ""
            indirizzoResa.CAP = ""
            indirizzoResa.Comune = ""
            indirizzoResa.Provincia = ""
            indirizzoResa.Nazione = ""
            datiTrasporto.IndirizzoResa = indirizzoResa
            datiTrasporto.DataOraConsegna = ""
            datiGenerali.DatiTrasporto = datiTrasporto
            Dim fatturaPrincipale As New FatturaPrincipale
            fatturaPrincipale.NumeroFatturaPrincipale = ""
            fatturaPrincipale.DataFatturaPrincipale = ""
            datiGenerali.FatturaPrincipale = fatturaPrincipale
            overviewBody.DatiGenerali = datiGenerali
            Dim datiBeniServizi As New DatiBeniServizi
            Dim dettaglioLinee As New DettaglioLinee
            Dim dettaglioLineeList As New List(Of DettaglioLinee)
            dettaglioLinee.NumeroLinea = ""
            dettaglioLinee.TipoCessionePrestazione = ""
            Dim codiceArticolo As New CodiceArticolo
            codiceArticolo.CodiceTipo = ""
            codiceArticolo.CodiceValore = ""
            dettaglioLinee.CodiceArticolo = codiceArticolo
            dettaglioLinee.Descrizione = ""
            dettaglioLinee.Quantita = ""
            dettaglioLinee.UnitaMisura = ""
            dettaglioLinee.DataInizioPeriodo = ""
            dettaglioLinee.DataFinePeriodo = ""
            dettaglioLinee.PrezzoUnitario = ""
            Dim scontoMaggiorazione_221 As New ScontoMaggiorazione
            scontoMaggiorazione_221.Tipo = ""
            scontoMaggiorazione_221.Percentuale = ""
            scontoMaggiorazione_221.Importo = ""
            dettaglioLinee.ScontoMaggiorazione = scontoMaggiorazione_221
            dettaglioLinee.PrezzoTotale = ""
            dettaglioLinee.AliquotaIVA = ""
            dettaglioLinee.Ritenuta = ""
            dettaglioLinee.Natura = ""
            dettaglioLinee.RiferimentoAmministrazione = ""
            Dim altriDatiGestionali As New AltriDatiGestionali
            altriDatiGestionali.TipoDato = ""
            altriDatiGestionali.RiferimentoTesto = ""
            altriDatiGestionali.RiferimentoNumero = ""
            altriDatiGestionali.RiferimentoData = ""
            dettaglioLinee.AltriDatiGestionali = altriDatiGestionali
            dettaglioLineeList.Add(dettaglioLinee)
            datiBeniServizi.DettaglioLinee = dettaglioLineeList
            Dim datiRiepilogo As New DatiRiepilogo
            Dim datiRiepilogoList As New List(Of DatiRiepilogo)
            datiRiepilogo.AliquotaIVA = ""
            datiRiepilogo.Natura = ""
            datiRiepilogo.SpeseAccessorie = ""
            datiRiepilogo.Arrotondamento = ""
            datiRiepilogo.ImponibileImporto = ""
            datiRiepilogo.Imposta = ""
            datiRiepilogo.EsigibilitaIVA = ""
            datiRiepilogo.RiferimentoNormativo = ""
            datiRiepilogoList.Add(datiRiepilogo)
            datiBeniServizi.DatiRiepilogo = datiRiepilogoList
            overviewBody.DatiBeniServizi = datiBeniServizi
            Dim datiVeicoli As New DatiVeicoli
            datiVeicoli.Data = ""
            datiVeicoli.TotalePercorso = ""
            overviewBody.DatiVeicoli = datiVeicoli
            Dim datiPagamento As New DatiPagamento
            datiPagamento.CondizioniPagamento = ""
            Dim dettaglioPagamento As New DettaglioPagamento
            dettaglioPagamento.Beneficiario = ""
            dettaglioPagamento.ModalitaPagamento = ""
            dettaglioPagamento.DataRiferimentoTerminiPagamento = ""
            dettaglioPagamento.GiorniTerminiPagamento = ""
            dettaglioPagamento.DataScadenzaPagamento = ""
            dettaglioPagamento.ImportoPagamento = ""
            dettaglioPagamento.CodUfficioPostale = ""
            dettaglioPagamento.CognomeQuietanzante = ""
            dettaglioPagamento.NomeQuietanzante = ""
            dettaglioPagamento.CFQuietanzante = ""
            dettaglioPagamento.TitoloQuietanzante = ""
            dettaglioPagamento.IstitutoFinanziario = ""
            dettaglioPagamento.IBAN = ""
            dettaglioPagamento.ABI = ""
            dettaglioPagamento.CAB = ""
            dettaglioPagamento.BIC = ""
            dettaglioPagamento.ScontoPagamentoAnticipato = ""
            dettaglioPagamento.DataLimitePagamentoAnticipato = ""
            dettaglioPagamento.PenalitaPagamentiRitardati = ""
            dettaglioPagamento.DataDecorrenzaPenale = ""
            dettaglioPagamento.CodicePagamento = ""
            datiPagamento.DettaglioPagamento = dettaglioPagamento
            overviewBody.DatiPagamento = datiPagamento
            Dim allegati As New Allegati
            allegati.NomeAttachment = ""
            allegati.AlgoritmoCompressione = ""
            allegati.FormatoAttachment = ""
            allegati.DescrizioneAttachment = ""
            allegati.Attachment = ""
            overviewBody.Allegati = allegati
            nodoPrincipale.FatturaElettronicaHeader = overviewHeader
            nodoPrincipale.FatturaElettronicaBody = overviewBody
            Dim XmlRoot As New XmlRootAttribute()
            XmlRoot.Namespace = "http://www.fatturapa.gov.it/sdi/fatturapa/v1.2"
            Dim myxmlAttribute As XmlAttributes = New XmlAttributes
            myxmlAttribute.XmlRoot = XmlRoot
            Dim xmlAttributeOverrides As XmlAttributeOverrides = New XmlAttributeOverrides
            xmlAttributeOverrides.Add(GetType(FatturaElettronica), myxmlAttribute)
            Dim emptyNsAttribute As New XmlAttributes()
            Dim xElement1 As New XmlElementAttribute()
            xElement1.Namespace = ""
            emptyNsAttribute.XmlElements.Add(xElement1)
            xmlAttributeOverrides.Add(GetType(FatturaElettronica), "FatturaElettronicaHeader", emptyNsAttribute)
            xmlAttributeOverrides.Add(GetType(FatturaElettronica), "FatturaElettronicaBody", emptyNsAttribute)
            nodoPrincipale.versione = "FPA12"
            Dim ser As New XmlSerializer(nodoPrincipale.[GetType](), xmlAttributeOverrides)
            ser = New XmlSerializer(nodoPrincipale.[GetType](), New XmlRootAttribute("pX"))
            Dim ns As New XmlSerializerNamespaces()
            ns.Add("ds", "http://www.w3.org/2000/09/xmldsig#")
            ns.Add("p", "http://ivaservizi.agenziaentrate.gov.it/docs/xsd/fatture/v1.2")
            ns.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance")
            Dim path = percorso & nome_file
            Dim file As System.IO.FileStream = System.IO.File.Create(path)
            ser.Serialize(New StreamWriter(file, New System.Text.UTF8Encoding()), nodoPrincipale, ns)
            file.Close()
            Dim delimiterToBeReplaced As String = "pX"
            Dim newDelimiter As String = "p:FatturaElettronica"
            Dim contents As String = System.IO.File.ReadAllText(path)
            contents = contents.Replace(delimiterToBeReplaced, newDelimiter)
            System.IO.File.WriteAllText(path, contents)
            esito = True
        Catch ex As Exception
            Return esito
        End Try
        Return esito
    End Function

    Private Sub BtnEseguiCodice_Click(sender As Object, e As EventArgs) Handles BtnEseguiCodice.Click
        Dim dir As String
        Dim nomeFile As String
        dir = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop) & "\"
        nomeFile = "DemoFatturaElettronica.xml"
        TxtPercorsoFile.Text = dir & nomeFile
        If genera_xml(dir, nomeFile) = False Then
            BtnEseguiCodice.Enabled = False
            BtnEseguiCodice.Text = "ATTENZIONE: si è verificato un errore!"
        Else
            BtnEseguiCodice.Enabled = False
            BtnEseguiCodice.Text = "Il file è stato generato correttamente!"
        End If
    End Sub

End Class