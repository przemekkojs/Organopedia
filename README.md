# Organopedia
Aplikacja mobilna będąca encyklopedią dot. budowy organów kościelnych.\
*Systemy Mobilne i Multimedia*

**autor**: Przemysław Kojs (266548)\
**grupa**: Grupa 1 (pon 18:55)

## 1. Założenia aplikacji
Projekt będzie swego rodzaju encyklopedią dot. piszczałek, wiatrownic, traktur oraz innych elementów związanych z budową organów kościelnych.
Zgodnie z poleceniem, ma być min. 12 produktów w 3 różnych kategoriach.

Propozycje kategorii oraz produktów w nich zawartych:
1. **Piszczałki** - smyczkowe, pryncypałowe, fletowe, językowe
2. **Wiatrownice** - klapowo-zasuwowe kanałowe, klapowo-zasuwowe z klapami wiszącymi, stożkowe górnozaworowe, stożkowe dolnozaworowe
3. **Traktury** - mechaniczna, pneumatyczna, elektro-pneumatyczna, mechaniczno-pneumatyczna
4. (*Rozszerzenie*) **Miechy** - klinowy, pływakowy, magazynowy, zasobnikowy

## 2. Technologia
.NET MAUI - język C#, platforma .NET 9.0 - zgodnie z akceptacją

## 3. Q&A

### 3.1. Skąd wezmę multimedia?
Ze zbioru własnych zdjęć, filmów i nagrań - jestem organistą, nie będzie problemu. Te, których z przyczyn dostępności nie uda się uzyskać,
pozyskam z zasobów internetu.

### 3.2. Dlaczego nie Kotlin?
Jestem znacznie bardziej pewny w ekosystemie .NETa, taka aplikacja to świetna okazja na poznanie platformy MAUI od strony mobilnej

### 3.3. Po co taka aplikacja?
Organy od zawsze są niedowartościowane, mało kto o nie dba - już z kronik Diecezji Krakowskiej z XVII/XVIII w. można to wywnioskować. Taka aplikacja może
posłużyć w walce ze stereotypem oraz otworzyć mi drogę do wielu ciekawych instrumentów, jeżeli chciałbym ją kiedyś rozwinąć.

## 4. Wymagania
W tej sekcji opisane zostały wymagania funkcjonalne (jak program ma działać) oraz niefunkcjonalne (ograniczenia) projektu.

### Wymagania funkcjonalne

#### Tryb offline
- Aplikacja musi działać bez dostępu do Internetu, umożliwiając pełne korzystanie z jej funkcjonalności.

#### Odtwarzanie filmów
- Użytkownik może odtwarzać filmy zapisane w aplikacji.
- Odtwarzacz powinien obsługiwać podstawowe funkcje: play, pause, przewijanie, zmiana głośności.

#### Galeria zdjęć
- Aplikacja powinna umożliwiać przeglądanie kolekcji zdjęć w formie siatki lub listy.

#### Podgląd zdjęcia
- Po kliknięciu na zdjęcie, otwiera się ono w trybie podglądu na pełnym ekranie.
- Użytkownik może powiększać zdjęcie gestem „szczypania” (pinch-to-zoom).

#### Opisy multimediów
- Każde zdjęcie i film powinny mieć przypisany opis, który będzie widoczny w trybie podglądu.

#### Intuicyjne menu nawigacyjne
- Aplikacja powinna zawierać menu umożliwiające szybki dostęp do filmów, galerii i ustawień.

#### Nowoczesny interfejs użytkownika
- UI powinno być estetyczne, zgodne z najnowszymi trendami UX/UI.

### Wymagania niefunkcjonalne

#### Wydajność
- Aplikacja powinna działać płynnie na urządzeniach mobilnych o średnich parametrach sprzętowych.

#### Responsywność interfejsu
- Elementy UI powinny dynamicznie dostosowywać się do różnych rozdzielczości ekranów.

#### Łatwość użytkowania
- Aplikacja powinna być intuicyjna i nie wymagać długiego procesu nauki.

#### Bezpieczeństwo danych
- Treści multimedialne powinny być przechowywane lokalnie w sposób zabezpieczony przed nieautoryzowanym dostępem.

#### Kompatybilność
- Aplikacja powinna działać na systemach Android.

#### Minimalistyczny design
- UI powinno unikać zbędnych elementów, stawiając na prostotę i przejrzystość.

#### Optymalizacja zużycia energii
- Aplikacja powinna minimalizować obciążenie procesora i baterii.

#### Szybki czas uruchamiania
- Czas startu aplikacji nie powinien przekraczać 3 sekund.

#### Obsługa gestów
- Aplikacja powinna wspierać gesty dotykowe, takie jak przesuwanie (swipe), powiększanie (pinch-to-zoom) i podwójne stuknięcie (double-tap).

#### Dostępność
- UI powinno być zgodne z wytycznymi dotyczącymi dostępności (np. odpowiedni kontrast, obsługa czytników ekranowych).

## 5. Kroje pisma, efekty tekstowe itp.
**5.1. Pliki graficzne**: format .jpeg\
**5.2. Pliki video**: format .mp4, kodek H.265\
**5.3. Pliki audio**: format .aac\
**5.4. Krój pisma**: Roboto, bezszeryfowa\
**5.5. Efekty tekstowe**: Cień, pogrubienie, kursywa, podkreślenie

## 6. Źródła graficzne
[Model telefonu](https://www.freepik.com/free-vector/new-modern-realistic-front-view-black-iphone-mockup-isolated-white-mobile-template-vector_33632328.htm#fromView=keyword&page=1&position=1&uuid=6e918124-cbae-458d-b878-4339da11c9e0&query=Mockup+Phone)