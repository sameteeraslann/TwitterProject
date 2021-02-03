
1- TwitterProject ad�nda BlankSolution a��l�r

2- TwitterProject.Domain ad�nda Class Library(.Core) Projesi a��l�r.
	2.1 Enums klas�r� a��l�r.
		2.1.1 Bu klas�r alt�na Status.cs a��l�r.

	 
	2.2 Entities klasr� a��l�r. 
		2.2.1 Interface klas�r� a��l�r ve bu klas�r alt�na IBaseEntity.cs interface'si a��l�r.

		2.2.2. Concrete klas�r� a��l�r. Bu klas�r�de projemizde ihtiya� duyulan s�n�flar olu�turulur.
			2.2.2.1 Child s�n�flara kal�t�m vermek ama�l� BaseEntity.cs a��l�r, abstract olarak i�aretlenir, IBaseEntity'den implement al�n�r ve IBaseEntity'de yazd���m�z propertyler burada g�vde kazan�r.

            2.2.2.2 AppRole.cs a��l�r.
            Not: Kullan�c� ile ilgili i�lemlerde Asp .Net Core Identity s�n�f�ndan yararlanaca��m. Bu ba�lamda AppUserRole ve AppUser s�n�flar�nda Identity s�n�fdan kal�t�m alacaklar. Bunu i�in Microsoft.Extensions.Identity.Store paketini y�kleyece�iz.

            2.2.2.3 AppUser.cs a��l�r.
			2.2.2.4 Follow.cs a��l�r.
			2.2.2.5 Mention.cs a��l�r.
			2.2.2.6 Like.cs a��l�r.
			2.2.2.7 Share.cs a��l�r.
			2.2.2.8 Tweet.cs a��l�r.

	2.3 Repositories klas�r� a��l�r. Projede temel anlamda CRUD operasyonlar�n� y�r�tece�im methodlar� asenkron programing'e uygun �ekilde olu�turaca��m.
		2.3.1 BaseRepo kls�r� a��l�r i�ine IRepository interfaces eklenir.
		Not: Microsoft.EntityFremeworkCore(5.0.2) Nuget Package Manager'den y�klenir.
		Not: GenericRepository Pattern, DIP kullanaca��m�z i�in her Concrete s�n�f i�in Repository a�aca��z.
		2.3.2 EntityTypeRepo klas�r� a��l�r.
			

