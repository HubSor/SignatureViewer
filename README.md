# SignatureViewer

Pozwala podejrzeæ stopkê mailow¹ ze skrzynki Exchange po podaniu adresu email i has³a.
Jest te¿ opcja obejrzenia stopki z domyœlnego konta outlook z maszyny lokalnej.

## Jak ulepszyæ ten program:

### Pod wzglêdem bezpieczeñstwa

Po x nieudanych próbach logowania mo¿na by blokowaæ tak¹ mo¿liwoœæ na jakiœ czas.

Po pierwszym logowaniu na danym koncie na danej maszynie, mo¿na by zostawiæ o tym informacjê na tej skrzynce (po zakoñczeniu sesji), ¿eby u¿ytkownik móg³ zdecydowaæ, czy to by³o w³amanie.

Istnieje cieñ szansy na atak typu injection, podaj¹c jako mail lub has³o spreparowany ci¹g znaków.
Sama funkcja AutodiscoverUrl chyba nie jest podatna, gdy¿ rzuca wyj¹tek w takich przypadkach, ale bardziej zaawansowana funkcja walidacji powinna rozwi¹zaæ problem niebezpiecznych linków.
(obecnie u¿ywana prosta wersja ze strony Microsoftu)

Mo¿e da siê spreparowaæ stopkê, ¿eby zawiera³a ukryty, niebezpieczny kod do wykonania, ale tutaj jest tylko pokazywana tekstowo i takie rzeczy mog³yby byæ wy³apywane przy ustawieniu jej na stronie.
Ciekawe zagadnienie, pewnie wymaga³oby rzetelnych testów bezpieczeñstwa.

### Pod wzglêdem efektywnoœci dzia³ania

Jeœli da siê, u¿yæ biblioteki / frameworka, która pozwala na pobieranie stopek z OWA a nie tylko Exchange lub lokalnego Outlooka.

Program dosyæ d³ugo ³¹czy siê do skrzynki, u¿ycie innej biblioteki mog³oby to przyspieszyæ, ale nie uda³o mi siê takiej znaleŸæ.

Mo¿na by dodaæ jak¹œ sensown¹ ikonkê lub animacjê podczas ³¹czenia siê do skrzynki, co chwilê zajmuje.

"Upiêkszyæ UI", gdy¿ jest zrobione bardzo minimalistycznie. Jest to bardzo prosta aplikacja, wiêc nie musi mieæ rozbudowanego UI.

Przy du¿ej rozbudowie tej aplikacji potrzebna by by³a porz¹dna i rzetelna dokumentacja.

### Pod wzglêdem obs³ugi b³êdów

System logowania zostawiaj¹cy logi o ka¿dej akcji podjêtej przez program. Potencjalnie przydatne przy programie pozwalaj¹cym podejrzeæ czyjeœ dane (nawet tak trywialne jak stopka mailowa).

Bardziej informatywne informowanie u¿ytkownika o zaistnia³ych b³êdach, np. w³asne klasy wyj¹tków i rozbudowane opisy.

