# 30/11/2020  
-Sperimentazione Funzione "OnMouseDown" e della vibrazione sul telefono(vibrazione non funziona in simulazione, va installata l'applicazione sul dispositivo)
-Inserimento di uno sprite come Background nero dietro allo sprite della stanza, perchè eseguito il gioco su uno smartphone non 16:9 i bordi risultano blu (test su samsung Galaxy S9)
(Sprite Nero e Sprite della stanza sono nello stesso Sorting Layer ma lo sprite nero è nell'order in Layer -1 mentre la stanza a 0)

# 07/12/2020 
-Sperimentazione con il nuovo input system di Unity, non necessario per il progetto vista la più semplice implementazione del Touch con il vecchio sistema di input

# 08/12/2020  
-Considerato che, il gioco utilizzerà tre sistemi di input: mouse, touch, controller. La parte di gestione degli input è stata modificata per poter inserire un cursore 
-spostabile con un controller e compatibile con il mouse e il touch.
-La nuova modalità di input ci permette di gestire ogni click indipendentemente dal tipo di controller utilizzato, avremo infatti un Gameobject chiamato "CursorController" 
-che si occupa di gestire gli input e muovere il vero e proprio cursore(Gameobject di nome CursorEvents)
-Il vero e proprio cursore "CursorEvents" farà partire un raycast alla sua attuale posizione per permetterci di capire quale collider stiamo colpendo dandoci più flessibiltà di un 
-classico button di unity, possiamo infatti modificare l'oggetto come preferiamo e creare un collider apposito, con diverse forme
-Due parametri sono stati inseriti per controllare la velocità con la quale si possa muovere cursore con il mouse e il controller
