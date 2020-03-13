![FatturaElettronica](https://etabetaweb.files.wordpress.com/2018/11/fattura-elettronica.jpg)

# Fattura Elettronica
Il progetto nasce dall’esigenza di creare una classe che permetta di rappresentare tutti i nodi previsti nel formato XML  (eXtensible Markup Language) della Fattura Elettronica basato sulla versione 1.3 delle specifiche tecniche dell’Agenzia delle Entrate. Sviluppato in Visual Basic .Net, utilizza il .Net Framework 4.6.



# Guida per l'utilizzo
E' disponibile la guida per l'implementazione della classe open source per la generazione della Fattura Elettronica. In esclusiva sullo store Amazon Kindle Book in formato digitale. La guida spiega come procedere all'implementazione della classe per la realizzazione di applicazioni contabili che prevedano l'emissione della fattura elettronica

![CopertinaGuida](https://etabetaweb.files.wordpress.com/2018/11/copertina-guida-fatturael.jpg) 

[ACQUISTA ONLINE](https://amzn.to/2A4D4aN)

Tra gli argomenti trattati:
* La fattura elettronica

* La fattura elettronica e le differenze con la fattura cartacea

* I vantaggi della fattura elettronica

* Le informazioni obbligatorie

* La struttura del file XML

* XML: visione generale 9

* Come trasmettere il file XML

* Download del codice sorgente e del file di libreria

* Organizzazione del repository

* Utilizzo della libreria compilata in Visual Studio

* Aggiunta del riferimento alla dll

* Aggiunta dei riferimenti ai namespace

* Aggiunta dell’istanza alla classe

* Utilizzo del progetto FatturaEL.v13 in Visual Studio

* Aggiunta del progetto ad una soluzione

* Aggiunta dei riferimenti ai namespace

* Aggiunta dell’istanza alla classe

* Utilizzo dei metodi e delle proprietà della classe

* Aggiunta di un metodo con occorrenza singola

* Assegnazione del valore ad una proprietà del metodo

* Assegnazione del metodo figlio al metodo padre

* Aggiunta di un metodo con occorrenza multipla

* Assegnazione delle proprietà al nodo con occorrenza multipla

* Codice di esempio

  

# Download della libreria compilata
Dal percorso "[/FatturaEL.v13/bin/Release/](https://github.com/EtabetaWeb/FatturaElettronica.v13/tree/master/FatturaEL.v13/bin/Release)" è possibile scaricare il file di libreria "FatturaEL.v13.dll" basato sulla versione 1.3 delle specifiche tecniche dell’Agenzia delle Entrate e compilata per l'integrazione in altre applicazioni.



# Note al codice di esempio per generare la Fattura Elettronica
Il form è un esempio per utilizzare, tramite code-behind, i metodi e le proprietà della classe. Il codice non è esaustivo, in quanto non utilizza tutti i metodi della classe, e vi rimando alle specifiche tecniche dell'Agenzia delle Entrate per l'elenco completo dei nodi previsti.
Il codice principale si trova nella funzione GeneraXML e i parametri sono passati direttamente da codice ma possono essere passati anche tramite campi TextBox con le opportune modifiche.
Il codice è commentato per comprendere come istanziare i vari metodi e le proprietà. La classe prevede due metodi principali "FatturaHeader" e "FatturaBoody". Questi sono i due nodi principali del file XML che racchiudono tutti i nodi figlio contenenti le informazioni previste dalla fattura elettronica.

Dal codice di esempio è possibile comprendere come:
- aggiungere un nodo con occorrenza singola;
- assegnare il valore alla proprietà di un nodo con occorrenza singola;
- assegnare il nodo figlio al nodo padre;
- aggiungere un nodo con occorrenza multipla;
- assegnazione delle proprietà al nodo con occorrenza multipla;

Inoltre, il codice serializza il file XML e lo salva sul computer.



# Composizione della soluzione
FatturaElettronica.sln si compone delle seguenti cartelle:
* Documenti/File Dati: file .txt contenenti i codici elencati nel documento di specifiche tecniche versione 1.3;

* Documenti/Specifiche Tecniche: documentazione tecnica dell’Agenzia delle Entrate del formato Fattura EL versione 1.3;

* FatturaEL.v13: file sorgenti in formato Visual Basic .Net con le definizioni del file XML versione 1.3;

* GeneraFatturaEL.v13: form di esempio per l'accesso ai metodi e proprietà della classe FatturaEL.v13;

* FatturaEL.v13/bin/Release: file di libreria (.dll compilata) per l'integrazione in altre applicazioni;

  

# Note
L'assembly version è costituito di 4 parti ({Major Version}.{Minor Version}.{Build Number}.{Revision}):
* Major Version: incrementata manualmente quando sono aggiunte/modifiche di funzionalità

* Minor Version: incrementata manualmente quando sono eseguite modifiche a bug fixes

* Build Number: incrementata automaticamente

* Revision: incrementata automaticamente

  

# Documentazione di riferimento
* [Specifiche tecniche dell'Agenzia delle Entrate](https://github.com/EtabetaWeb/FatturaElettronica.v13/tree/master/Documentazione/Specifiche%20Tecniche)



#### Elenco degli aggiornamenti inseriti dall'Agenzia delle Entrate con la versione 1.3

- Allegato A - Specifiche tecniche (versione 1.3) in italiano: per correggere un refuso sull’elemento CausalePagamento che deve essere compilato con il codice corrispondente a quello utilizzato per la compilazione del modello CU, in particolare sono stati corretti i paragrafi 2.1.7, 2.2.9.1 e l’appendice 3;
- Allegato A - Specifiche tecniche (versione 1.3) in inglese: per correggere un refuso sull’elemento CausalePagamento che deve essere compilato con il codice corrispondente a quello utilizzato per la compilazione del modello CU, in particolare sono stati corretti i paragrafi 2.1.7, 2.2.9.1 e l’appendice 3 (la descrizione tipo Natura N5 è stata completata aggiungendo la dicitura “IVA non esposta in fattura”);
- Rappresentazione tabellare del tracciato fattura ordinaria in italiano per correggere dei refusi:
  o nella descrizione del controllo extra schema relativo alla valorizzazione dell'elemento informativo 1.1.1.1 <IdPaese> con "IT", in tal caso viene verificato che il Codice Fiscale sia censito in Anagrafe Tributaria o sull’elemento 2.1.1.5.4 <CausalePagamento> che, nella descrizione funzionale indica che i valori ammessi per la compilazione sono quelli utilizzati per la compilazione del modello CU, ove applicabili;
- Rappresentazione tabellare del tracciato fattura ordinaria in inglese, per correggere dei refusi:
  o nella descrizione del controllo extra schema relativo alla valorizzazione dell'elemento informativo 1.1.1.1 <IdPaese> con "IT", in tal caso viene verificato che il Codice Fiscale sia censito in Anagrafe Tributaria o sull’elemento 2.1.1.5.4 <CausalePagamento> che, nella descrizione funzionale indica che i valori ammessi per la compilazione sono quelli utilizzati per la compilazione del modello CU, ove applicabili o la descrizione del tipo Natura N5 è stata completata aggiungendo la dicitura “IVA non esposta in fattura”;
- Rappresentazione tabellare del tracciato fattura semplificata in italiano per correggere dei refusi:
  o nella descrizione del controllo extra schema relativo alla valorizzazione dell'elemento informativo 1.1.1.1 <IdPaese> con "IT", in tal caso viene verificato che il Codice Fiscale sia censito in Anagrafe Tributaria o la descrizione del tipo Natura N5 è stata completata aggiungendo la dicitura “IVA non esposta in fattura” o è stato rimosso dalla lista dei “Regimi fiscali” il codice RF03 Nuove iniziative produttive(art.13, L. 388/00);
- Rappresentazione tabellare del tracciato fattura semplificata in inglese per correggere dei refusi:
  o nella descrizione del controllo extra schema relativo alla valorizzazione dell'elemento informativo 1.1.1.1 <IdPaese> con "IT", in tal caso viene verificato che il Codice Fiscale sia censito in Anagrafe Tributaria o la descrizione del tipo Natura N5 è stata completata aggiungendo la dicitura “IVA non esposta in fattura”; 
- Specifiche tecniche in italiano (versione 1.3) per inserire l’indirizzo PEC sdi01@pec.fatturapa.it a cui il soggetto trasmittente invia la fattura la prima volta;
- Specifiche tecniche in inglese (versione 1.3) per correggere un refuso nel paragrafo “Document status” nel quale è indicato, relativamente all’introduzione del nuovo controllo, un numero di pagina sbagliato (139 anziché 137) e per inserire l’indirizzo PEC sdi01@pec.fatturapa.it a cui il soggetto trasmittente invia la fattura la prima volta;
- Rappresentazione tabellare del tracciato fattura semplificata (versione 1.1 – xls) in italiano per correggere l’assenza il valore TD09 nota di debito semplificata dalla lista dei codici per indicare il <TipoDocumento>;