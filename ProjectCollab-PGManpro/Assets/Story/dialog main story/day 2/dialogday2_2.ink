VAR player = "player"
VAR David = "David"
VAR Alvin = "Alvin"
VAR Vin = "Vin"
VAR Vid = "Vid"
VAR jajan = "jajan"
->day2



//Day 2
=== day2 ===
Nahh ini kita udah sampai ke tempatnya. #speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
Wah jauh juga ya. Jadi kamu mau ngajari aku apa, {Vid} ?? #speaker:{player} #score: 0 #stress: 0 #blackscreen: 0
Kamu udah tau kan kalau di sekolah ini banyak bullying ?#speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
Iyaa aku udah di kasih tau sama {Alvin}.#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0
Aku punya cara buat kamu biar gak dibully selama sekolah disini.#speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
Oh ya ?? Gimana cara nya, {Vid}?#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0
Caranya gampang, kamu cuma perlu nuruti omongan ku aja kok. #speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
Sama kamu kan punya {jajan}. #speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
Nah kamu cuma perlu kasih i kita kalau kita butuh aja. Lalu kita pastiin kamu gak bakal di bully lagi.#speaker:{David} #score: 0 #stress: 0 #blackscreen: 0

Loh apa cuma itu caranya, {Vid}?#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0
(Loh itu kan sama aja kayak dia malak aku)#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0

Itu cuma satu-satunya cara buat kamu gak dibully sih. Tapi kalau kamu gak ngikuti caraku pasti hidupmu di sekolah jadi gak enak.#speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
+ [Turuti perintah {David} dan berikan {jajan} ke {David}]
    Ya udah, {Vid}. Aku ngikuti kamu aja.#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0 #item: -1
    Nahh baguss, sekarang kamu ada {jajan} kan. #speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
    Kamu tinggal kasih itu ke kita sekarang aku pastiin aku gak bakal di bully di sekolah ini.#speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
    Iyaa ini, {Vid}.#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0
    {player} menyerah dan memberikan {jajan} yang ia miliki#speaker:narrator #score: 50 #stress: 5 #blackscreen: 4 
    -> DONE
+ [Lawan {David} dan tidak berikan {jajan} ke {David}]
    Itu kan ya sama aja kalau kamu malak i aku. Aku gak mau kasih {jajan} ku ke kamu.#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0
    Yakin itu pilihan mu ?? Guys kalian ada yang stress gak ? kek biasae aja. awokwaowka.#speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
    Kek biasae ??Woke boss siapp. Hahahahaha.#speaker:Geng {David} #score: 0 #stress: 0 #blackscreen: 0
    {player} dibully oleh {David} dan geng nya#speaker:narrator #score: 200 #stress: 20 #blackscreen: 3
    -> DONE
-> END