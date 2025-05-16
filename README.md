# Organopedia
Aplikacja mobilna będąca encyklopedią dot. budowy organów kościelnych.\
*Systemy Mobilne i Multimedia*

## 1. Założenia aplikacji
Projekt będzie swego rodzaju encyklopedią dot. piszczałek, wiatrownic, traktur oraz innych elementów związanych z budową organów kościelnych.
Zgodnie z poleceniem, ma być min. 12 produktów w 3 różnych kategoriach.

Propozycje kategorii oraz produktów w nich zawartych:
1. **Piszczałki** - labialne drewniane, labialne metalowe, językowe
2. **Wiatrownice** - skrzyniowe, rejestrowe, tonowe
3. **Traktury** - mechaniczna, pneumatyczna, elektryczna
4. **Miechy** - klinowy, pływakowy, poziomy

## 2. Technologia
.NET MAUI - język C#, platforma .NET 9.0

## 3. Q&A

### 3.1. Skąd wezmę multimedia?
Ze zbioru własnych zdjęć, filmów i nagrań - jestem organistą, nie będzie problemu. Te, których z przyczyn dostępności nie uda się uzyskać,
pozyskam z zasobów internetu.

### 3.2. Dlaczego nie Kotlin?
Jestem znacznie bardziej pewny w ekosystemie .NET'a, taka aplikacja to świetna okazja na poznanie platformy MAUI od strony mobilnej

### 3.3. Po co taka aplikacja?
Organy od zawsze są niedowartościowane, mało kto o nie dba - już z kronik Diecezji Krakowskiej z XVII/XVIII w. można to wywnioskować. Taka aplikacja może posłużyć w walce ze stereotypem oraz otworzyć mi drogę do wielu ciekawych instrumentów, jeżeli chciałbym ją kiedyś rozwinąć.

## 4. Wymagania
W tej sekcji opisane zostały wymagania funkcjonalne (jak program ma działać) oraz niefunkcjonalne (ograniczenia) projektu.

### Wymagania funkcjonalne

#### Tryb offline
Aplikacja musi działać bez dostępu do Internetu, umożliwiając pełne korzystanie z jej funkcjonalności.

#### Odtwarzanie filmów
- Użytkownik może odtwarzać filmy zapisane w aplikacji.
- Odtwarzacz powinien obsługiwać podstawowe funkcje: play, pause, przewijanie, zmiana głośności.

#### Galeria zdjęć
Aplikacja powinna umożliwiać przeglądanie kolekcji zdjęć w formie listy.

#### Podgląd zdjęcia
- Po kliknięciu na zdjęcie, otwiera się ono w trybie podglądu na pełnym ekranie.
- Użytkownik może powiększać zdjęcie gestem *szczypania* (pinch-to-zoom).

#### Opisy multimediów
Każde zdjęcie i film powinny mieć przypisany opis, który będzie widoczny w trybie podglądu.

#### Intuicyjne menu nawigacyjne
Aplikacja powinna zawierać menu umożliwiające szybki dostęp do ustawień.

#### Nowoczesny interfejs użytkownika
UI powinno być estetyczne, zgodne z najnowszymi trendami UX/UI.

### Wymagania niefunkcjonalne

#### Wydajność
Aplikacja powinna działać płynnie na urządzeniach mobilnych o średnich parametrach sprzętowych.

#### Responsywność interfejsu
Elementy UI powinny dynamicznie dostosowywać się do różnych rozdzielczości ekranów.

#### Łatwość użytkowania
Aplikacja powinna być intuicyjna i nie wymagać długiego procesu nauki.

#### Bezpieczeństwo danych
Treści multimedialne powinny być przechowywane lokalnie w sposób zabezpieczony przed nieautoryzowanym dostępem.

#### Kompatybilność
Aplikacja powinna działać na systemach Android.

#### Minimalistyczny design
UI powinno unikać zbędnych elementów, stawiając na prostotę i przejrzystość.

#### Optymalizacja zużycia energii
Aplikacja powinna minimalizować obciążenie procesora i baterii.

#### Szybki czas uruchamiania
Czas startu aplikacji nie powinien przekraczać 3 sekund.

#### Obsługa gestów
Aplikacja powinna wspierać gesty dotykowe, takie jak przesuwanie (swipe) czy powiększanie (pinch-to-zoom).

#### Dostępność
UI powinno być zgodne z wytycznymi dotyczącymi dostępności (np. odpowiedni kontrast, obsługa czytników ekranowych).

## 5. Kroje pisma, efekty tekstowe itp.
**5.1. Pliki graficzne**: format .png\
**5.2. Pliki video**: format .mp4, kodek H.265\
**5.3. Pliki audio**: format .aac\
**5.4. Krój pisma**: OpenSans, bezszeryfowa\
**5.5. Efekty tekstowe**: Cień, pogrubienie

## 6. Źródła graficzne
- [Model telefonu na ulotce](https://www.freepik.com/free-vector/new-modern-realistic-front-view-black-iphone-mockup-isolated-white-mobile-template-vector_33632328.htm#fromView=keyword&page=1&position=1&uuid=6e918124-cbae-458d-b878-4339da11c9e0&query=Mockup+Phone)
- [Ikony w menu hamburgerowym](https://fonts.google.com/icons?preview.layout=grid) - wszystkie pochodzą od GoogleFonts, udostępnionych na licencji OpenSource.
- Źródła własne - zdjęcia, filmy oraz materiały audio z rzeczywistych organów. Wykonane za zgodą opiekunów instrumentów.

## 7. Wykorzystane narzędzia
- [Figma](https://www.figma.com/) - edycja Student
- [Pencil](https://pencil.evolus.vn/Licensing.html) - darmowy program OpenSource do prototypowania, na licencji **GNU v2**
- [GIMP 2.10.32](https://www.gimp.org/about/COPYING) - darmowy program graficzny Open Source, na licencji **GNU v3**
- [Visual Studio Community 2022](https://visualstudio.microsoft.com/pl/vs/community/) - darmowe IDE od Microsoft, bogate w pakiety jak .NET Maui
- [Visual Studio Code](https://code.visualstudio.com/) - darmowe IDE od Microsoft
- [.NET 9.0 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/9.0) - SDK pozwalające na pracę w ekosystemie .NET. Wspierane przez VS Community.
- [MAUI Community Toolkit](https://github.com/CommunityToolkit/Maui) - Zestaw open-source'owych elementów UI oraz funkcjonalności od społeczności MAUI.

## Wykorzystane zasady UI/UX w projekcie:

### Użyteczność
Podczas tworzenia aplikacji postawiłem na użyteczność każdego z komponentów - nie ma tam żadnej zbędnej kontrolki.

### KISS - Keep It Simple, Stupid
Minimalizm w designie - nie ma zbytniego efekciarstwa, wszystko jest klarowne i przejrzyste.

### Spójność
Elementy są otoczone spójną szatą graficzną, zachowanie elementów identycznie wyglądających jest tożsame.

### Zasada 3 kliknięć
Do dowolnego miejsca w aplikacji można zawsze dojść w maksymalnie 3 kliknięciach - od menu po galerię zdjęć.

### Dostępność
Materiały graficzne otrzymały teksty alternatywne, elementy UI otrzymały opisy, dzięki czemu aplikacja działa na czytnikach ekranowych.

## Kolorystyka aplikacji
Została dobrana tak, by jednocześnie być nowoczesna, elegancka oraz klasyczna. Dodatkowo wyraźne inspiracje instrumentami - złoto, czernie, biele oraz odcienie szarości bazujące na istniejących, współczesnych kontuarach. 

### Tryb jasny (Light mode)
**Kolor tła**: #FAFAFA\
**Kolor tekstu**: #212121\
**Kolor akcentu**: #D4AF37\
**Kolor obramowania**: #E0E0E0\
**Dodatkowy kolor tła**: #A0EEEEEE

### Tryb ciemny (Dark mode)
**Kolor tła**: #121212\
**Kolor tekstu**: #E0E0E0\
**Kolor akcentu**: #FFD700\
**Kolor obramowania**: #333333\
**Dodatkowy kolor tła**: #80222222

### Tryb wysokiego kontrastu (High contrast mode)
**Kolor tła**: #000000\
**Kolor tekstu**: #FFFFFF\
**Kolor akcentu**: #FFFF00\
**Kolor obramowania**: #FFFFFF\
**Dodatkowy kolor tła**: #000000

## Szkic aplikacji
Szkic aplikacji jest dostępny w folderze **wireframes/**. Przygotowany został w programie *Pencil*, można również zobaczyć wyeksportowanego interaktywnego PDFa z programu.

## Prototyp aplikacji
Prototyp dostępny jest pod linkiem: [Link do makiety projektu w witrynie proto.io](https://pr.to/BAQLXL/)

## Testy
Testy aplikacji objęły sprawdzenie działania elementów wyszukującym oraz dostępności każdego z ważniejszych ekranów. Przeprowadzone zostały na platformie Windows, z uwagi na niekompatybilne pakiety z moim urządzeniem (API 34). Użyte zostały:
- Appium
- WinAppDriver
- NUnit
- Microsoft.Test.Sdk