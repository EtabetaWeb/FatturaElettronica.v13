![FatturaElettronica](https://etabetaweb.files.wordpress.com/2018/11/fattura-elettronica.jpg)

# Fattura Elettronica versione 1.3
**Il progetto è stato deprecato a favore della libreria [FatturaElettronica.XMLNodes](https://github.com/EtabetaWeb/FatturaElettronica) (sviluppata in C# .NET Standard 2.0). Il codice open source viene comunque mantenuto on line con la finalità di studio.**

------

Il progetto nasce dall'esigenza di creare una **libreria** che permetta di rappresentare tutti i **nodi previsti nel formato XML** (eXtensible Markup Language) della **Fattura Elettronica**. Basata sulla **versione 1.3** delle **specifiche tecniche dell’Agenzia delle Entrate**, la **libreria** è sviluppata in **Visual Basic** ed utilizza il **Net Framework 4.6**. 



# Organizzazione del repository

FatturaElettronica.sln si compone delle seguenti cartelle:

* **Documenti/File Dati**: file .txt contenenti i codici elencati nel documento di specifiche tecniche versione 1.3;

* **Documenti/Specifiche Tecniche**: documentazione tecnica dell’Agenzia delle Entrate del formato Fattura EL versione 1.3;

* **FatturaEL.v13**: file sorgenti in formato Visual Basic .Net con le definizioni del file XML versione 1.3;

* **FatturaEL.v13/bin/Release**: file di libreria (.dll compilata) per l'integrazione in altre applicazioni;

* **GeneraFatturaEL.v13**: form di esempio per l'accesso ai metodi e proprietà della classe FatturaEL.v13;

  

# Note al codice di esempio

La soluzione comprende un esempio per utilizzare, tramite code-behind, i metodi e le proprietà della libreria.

**Il codice di esempio non è esaustivo, in quanto non utilizza tutti i metodi della classe. Si prega di fare riferimento alle specifiche tecniche dell'Agenzia delle Entrate per l'elenco completo dei nodi previsti**.

Il codice principale si trova nella funzione GeneraXML e i parametri sono passati direttamente da codice ma possono essere passati anche tramite campi TextBox con le opportune modifiche.

La classe prevede due metodi principali "FatturaHeader" e "FatturaBoody". Questi sono i due nodi principali del file XML che racchiudono tutti i nodi figlio contenenti le informazioni previste dalla fattura elettronica.

**Dal codice di esempio è possibile comprendere come**:

- aggiungere un nodo con occorrenza singola;
- assegnare il valore alla proprietà di un nodo con occorrenza singola;
- assegnare il nodo figlio al nodo padre;
- aggiungere un nodo con occorrenza multipla;
- assegnazione delle proprietà al nodo con occorrenza multipla;

Inoltre, il codice serializza il file XML e lo salva sul computer.



# Download della libreria compilata
Dal percorso "[/FatturaEL.v13/bin/Release/](https://github.com/EtabetaWeb/FatturaElettronica.v13/tree/master/FatturaEL.v13/bin/Release)" è possibile **scaricare il file di libreria** "FatturaEL.v13.dll" basato sulla versione 1.3 delle specifiche tecniche dell’Agenzia delle Entrate e **compilata per l'integrazione in altre applicazioni**.




# Guida per l'utilizzo

![copertina libro](https://etabetaweb.files.wordpress.com/2022/09/cover-libro-fatturael-v13-ed-2.jpg?w=640)

In **esclusiva** sullo store [**Amazon**](https://amzn.to/3Sb92ZG) è disponibile, in **formato digitale**, la **guida all'utilizzo della libreria** open source per la generazione della Fattura Elettronica.

**La guida si rivolge**, principalmente, agli **sviluppatori principianti** che desiderano utilizzare la libreria nei loro programmi. 

**Nella guida** sono contenuti i **commenti al codice di esempio** non altrimenti recuperabili dai sorgenti presenti nel repository di GitHub.

Vi sono anche **informazioni utili** che possono essere utilizzate da **utenti avanzati** che vogliono **approfondire alcune tematiche relative alla Fatturazione Elettronica**.

È importante che il lettore abbia **familiarità con lo sviluppo del software** e con i concetti base della **programmazione ad oggetti**.



[[ACQUISTA ONLINE](https://amzn.to/3Sb92ZG)]



### Indice dei contenuti

- La fattura elettronica;
- La fattura elettronica e le differenze con la fattura cartacea;
- I vantaggi della fattura elettronica;
- Le informazioni obbligatorie;
- La struttura del file XML;
- XML: visione generale;
- Come trasmettere il file XML;
- Download del codice sorgente e del file di libreria;
- Organizzazione del repository;
- Utilizzo della libreria compilata in Visual Studio;
- Aggiunta del riferimento alla dll;
- Aggiunta dei riferimenti ai namespace;
- Aggiunta dell’istanza alla classe;
- Utilizzo del progetto FatturaEL.v13 in Visual Studio;
- Aggiunta del progetto ad una soluzione;
- Aggiunta dei riferimenti ai namespace;
- Aggiunta dell’istanza alla classe;
- Utilizzo dei metodi e delle proprietà della classe;
- Aggiunta di un metodo con occorrenza singola;
- Assegnazione del valore ad una proprietà del metodo;
- Assegnazione del metodo figlio al metodo padre;
- Aggiunta di un metodo con occorrenza multipla;
- Assegnazione delle proprietà al nodo con occorrenza multipla;
- Codice di esempio in visual basic;
