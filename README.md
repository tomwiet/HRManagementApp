# HRManagementApp
ToDo TuuDam
1) Spis wszystkich pracownik�w firmy. -> jest
2) Interesuj� nas dane: imi�, nazwisko, data zatrudnienia, data zwolnienia, numer pracownika, uwagi i 
    wysoko�� zarobk�w. Mo�esz r�wnie� wprowadzi� inne dodatkowe informacje. -> jest
3) Dane przechowuj prosz� w pliku tekstowym. Mo�e to by� plik XML, ale mo�esz te� przechowywa� te dane w 
   formacie JSON. -> jest d�ejson ;)
4) Mo�liwo�� dodania nowego pracownika, aktualizowania jego danych. -> jest
5) Nie powinno by� mo�liwo�ci usuwania pracownika, ale musi by� mo�liwo�� zwalniania pracownika. 
   Ta funkcja powinna tylko ustawia� dat� zwolnienia. Dzi�ki takiemu mechanizmowi nie b�dziemy traci� na 
   przyk�ad historycznych danych o pracownikach je�eli zostan� zwolnieni. 
   Jest to dobre rozwi�zanie, cz�sto z takiego mechanizmu b�dziesz chcia� skorzysta� w r�nych aplikacjach.-> jest
6) Mo�esz doda� r�wnie� filtrowanie danych. Tak �eby mo�na by�o wy�wietla� wszystkich pracownik�w, 
   tylko zatrudnionych lub tylko zwolnionych. -> jest

Podpowiedzi:
Dla daty zwolnienia u�yj �DateTime?� � dzi�ki temu przy tworzeniu nowego pracownika ta data mo�e by� null�em. Je�eli chcesz zapisywa� dane w formacie JSON, to skorzystaj z biblioteki Newtonsoft.Json.

Zrefaktoryzowac kod Main.cs dla zdarzen buttona Edit i Dismiss