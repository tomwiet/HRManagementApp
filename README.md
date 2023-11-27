# HRManagementApp
ToDo TuuDam
1) Spis wszystkich pracowników firmy. -> jest
2) Interesuj¹ nas dane: imiê, nazwisko, data zatrudnienia, data zwolnienia, numer pracownika, uwagi i 
    wysokoœæ zarobków. Mo¿esz równie¿ wprowadziæ inne dodatkowe informacje. -> jest
3) Dane przechowuj proszê w pliku tekstowym. Mo¿e to byæ plik XML, ale mo¿esz te¿ przechowywaæ te dane w 
   formacie JSON. -> jest d¿ejson ;)
4) Mo¿liwoœæ dodania nowego pracownika, aktualizowania jego danych. -> jest
5) Nie powinno byæ mo¿liwoœci usuwania pracownika, ale musi byæ mo¿liwoœæ zwalniania pracownika. 
   Ta funkcja powinna tylko ustawiaæ datê zwolnienia. Dziêki takiemu mechanizmowi nie bêdziemy traciæ na 
   przyk³ad historycznych danych o pracownikach je¿eli zostan¹ zwolnieni. 
   Jest to dobre rozwi¹zanie, czêsto z takiego mechanizmu bêdziesz chcia³ skorzystaæ w ró¿nych aplikacjach.-> jest
6) Mo¿esz dodaæ równie¿ filtrowanie danych. Tak ¿eby mo¿na by³o wyœwietlaæ wszystkich pracowników, 
   tylko zatrudnionych lub tylko zwolnionych. -> jest

Podpowiedzi:
Dla daty zwolnienia u¿yj „DateTime?” – dziêki temu przy tworzeniu nowego pracownika ta data mo¿e byæ null’em. Je¿eli chcesz zapisywaæ dane w formacie JSON, to skorzystaj z biblioteki Newtonsoft.Json.

Zrefaktoryzowac kod Main.cs dla zdarzen buttona Edit i Dismiss