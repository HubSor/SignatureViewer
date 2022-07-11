# SignatureViewer

Pozwala podejrze� stopk� mailow� ze skrzynki Exchange po podaniu adresu email i has�a.
Jest te� opcja obejrzenia stopki z domy�lnego konta outlook z maszyny lokalnej.

## Jak ulepszy� ten program:

### Pod wzgl�dem bezpiecze�stwa

Po x nieudanych pr�bach logowania mo�na by blokowa� tak� mo�liwo�� na jaki� czas.

Po pierwszym logowaniu na danym koncie na danej maszynie, mo�na by zostawi� o tym informacj� na tej skrzynce (po zako�czeniu sesji), �eby u�ytkownik m�g� zdecydowa�, czy to by�o w�amanie.

Istnieje cie� szansy na atak typu injection, podaj�c jako mail lub has�o spreparowany ci�g znak�w.
Sama funkcja AutodiscoverUrl chyba nie jest podatna, gdy� rzuca wyj�tek w takich przypadkach, ale bardziej zaawansowana funkcja walidacji powinna rozwi�za� problem niebezpiecznych link�w.
(obecnie u�ywana prosta wersja ze strony Microsoftu)

Mo�e da si� spreparowa� stopk�, �eby zawiera�a ukryty, niebezpieczny kod do wykonania, ale tutaj jest tylko pokazywana tekstowo i takie rzeczy mog�yby by� wy�apywane przy ustawieniu jej na stronie.
Ciekawe zagadnienie, pewnie wymaga�oby rzetelnych test�w bezpiecze�stwa.

### Pod wzgl�dem efektywno�ci dzia�ania

Je�li da si�, u�y� biblioteki / frameworka, kt�ra pozwala na pobieranie stopek z OWA a nie tylko Exchange lub lokalnego Outlooka.

Program dosy� d�ugo ��czy si� do skrzynki, u�ycie innej biblioteki mog�oby to przyspieszy�, ale nie uda�o mi si� takiej znale��.

Mo�na by doda� jak�� sensown� ikonk� lub animacj� podczas ��czenia si� do skrzynki, co chwil� zajmuje.

"Upi�kszy� UI", gdy� jest zrobione bardzo minimalistycznie. Jest to bardzo prosta aplikacja, wi�c nie musi mie� rozbudowanego UI.

Przy du�ej rozbudowie tej aplikacji potrzebna by by�a porz�dna i rzetelna dokumentacja.

### Pod wzgl�dem obs�ugi b��d�w

System logowania zostawiaj�cy logi o ka�dej akcji podj�tej przez program. Potencjalnie przydatne przy programie pozwalaj�cym podejrze� czyje� dane (nawet tak trywialne jak stopka mailowa).

Bardziej informatywne informowanie u�ytkownika o zaistnia�ych b��dach, np. w�asne klasy wyj�tk�w i rozbudowane opisy.

