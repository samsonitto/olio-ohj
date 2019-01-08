
# Ohjeet

## Yleistä
Opiskelijan tulee forkata tämä repositorio omaan käyttöönsä ja toteuttaa 
Olio-ohjelmoinnin kotitehtävät forkkaamaansa repositorioon seuraavien ohjeiden mukaisesti.

## Repositorion forkkaaminen
Aivan aluksi opiskelijan tulee forkata (tavallaan ottaa tästä repositoriosta kopio) ensin itselleen gitlab.labranet.jamk.fi-palvelimelle. Tämä tapahtuu klikkaamalla
tämän repositorion fork-painiketta sivun yläosasta. Tämän jälkeen oma forkattu repositorio voidaan kloonata paikalliselle koneelle. Muista muuttaa permission privaatiksi ja lisää opettaja projektiin.

## Repositorion kloonaminen
Voit kloonata oman forkatun repositorion paikalliselle koneellesi seuraavasti:

1. Käynnistä Visual Studio ja avaa Team Explorer
2. Valitse Team Explorerista kohta "Local Git Repositories" ja sieltä "Clone"
3. Kopio oman forkatun repositorion URL selaimen osoitekentästä
4. Sijoita URL Team Explorerin "Enter the URL of a Git repo to clone" -kenttään
5. Määritä paikallisen koneen kansio, johon repositorio kloonataan
6. Paina Clone-painiketta
7. Syötä labranetin käyttäjätunnuksesi ja salasana ja paina OK-painiketta

Nyt repostioriosta on otettu klooni paikalliselle koneellesi.

1. Visual Studio avaa oletuksena Solution Explorerin näkyville
2. Valitse näkyville Team Explorer ja näet, että sinulle on uusi kloonattu paikallinen repositorio

## Uuden solutionin luominen
Jokaisen kontaktikerran kotitehtävät tulee toteuttaa oman solutionin sisälle. Tämän luodun solutionin sisällä tulee tehdä jokainen tehtävä omana projektina.

### Esimerkki
Voit luoda uuden solutionin repositorioon seuraavasti:
1. Tuplaklikkaa Team Explorerissa näkyvää lokaalia repositoriota, jolloin se tulee valituksi
2. Valitse Solution-kohdasta New... ja luo uusi solution (ja samalla ensimmäinen projekti)
    * Valitse Visual C# ja Console App (.NET Framework)
    * Name: T1 (tämä tarkoittaa tässä nyt siis Tehtävää 1)
    * Location: valitse tähän paikallisen repositorion sijainti (esim. c:\olio\olio-ohjelmointi-tehtavat)
    * Solution: Create a new solution
    * Solution name: KT01
    * Valitse Create directory for solution
    * ÄLÄ valitse Create new Git Repository (koska solution tulee jo ylemmän tason Git-repositorion alle == tämä repositorio, jonka kloonasit)
3. Paina OK-painiketta

Nyt Visual Studio generoi sinulle solutionin ja sen sisälle yhden projektin. Tämän jälkeen Program.cs-tiedosto on avoinna ja voit aloittaa koodaamisen!

## Muutosten kommitoiminen
Kun tekemäsi ohjelmoinnit ovat valmiita tulee sinun kommitoida muutokset paikalliseen repositorioon:
1. Valitse Team Explorerista Project-kohdasta Changes
2. Kirjoita kuvaava kommentti, joka koskee koodimuutoksia/lisäyksiäsi
3. Paina Commit All -painiketta ja tiedot tallentuvat paikalliseen repositorioon

Muutosten välittäminen gitlab.labranet.jamk.fi-palvelimella olevaan repositorioon:
4. Halutessasi voit myös samalla lähettää koodit gitlab.labranet.jamk-fi palvelimelle valitsemalla Commit All and Push
5. Myöhemmin voit myös valita Sync, jolloin versioiden yhteneväisyys tarkistetaan paikallisen ja gitlab.labranet.jamk.fi-palvelimen kesken 

## Rakenne
Alla on näkyvissä esimerkki repositorion rakenteesta:

|Tiedosto|Selite|
|--|--|
|README.md | tämä tiedosto |
|KT01 | Ensimmäisen kontaktikerran solution |
|KT01/T1 | Ensimmäisen kontaktikerran ensimmäinen tehtävä / projekti |
|KT01/T1/Program.cs | Ensimmäisen kontaktikerran ensimmäisen tehtävän tiedosto |
|...|...|
|KT01/T2/Program.cs | Ensimmäisen kontaktikerran toisen tehtävän tiedosto |
|...|...|
|KT02/T1/Program.cs | Toisen kontaktikerran ensimmäisen tehtävän tiedosto |
|...|...|

## Lopuksi
Näitä ohjeita noudattamalla sinulla on yksi ihana repositorio, jonka sisällä ovat olio-ohjelmointi-opintojakson kaikkien kertojen demotehtävät nätisti. Voit
tehdä ohjelmointia haluamassasi luokassa/kotona, kunhan muistat aina siirtää viimeisimmän version paikalliselta koneelta gitlab.labranet.jamk.fi repositorioon ja
ottaa sen sieltä taas käyttöösi paikalliselle koneelle.
