VAR player = "player"
VAR David = "David"
VAR Alvin = "Alvin"
VAR Vid = "Vid"
->day2



//Day 2
=== day2 ===
Nahh ini kita udah sampai ke tempatnya. #speaker:{David}
Wah jauh juga ya. Jadi kamu mau ngajari aku apa, {Vid} ?? #speaker:{player}
Kamu udah tau kan kalau di sekolah ini banyak bullying ?#speaker:{David}
Iyaa aku udah di kasih tau sama {Alvin}.#speaker:{player}
Aku punya cara buat kamu biar gak dibully selama sekolah disini.#speaker:{David}
Oh ya ?? Gimana cara nya, {Vid}?#speaker:{player}
Caranya gampang, kamu cuma perlu nuruti omongan ku aja kok. #speaker:{David}
Sama kamu kan punya jajan/bekal/uang. #speaker:{David}
Nah kamu cuma perlu kasih i kita kalau kita butuh aja. Lalu kita pastiin kamu gak bakal di bully lagi.#speaker:{David}

Loh apa cuma itu caranya, {Vid}?#speaker:{player}
(Loh itu kan sama aja kayak dia malak aku)#speaker:{player}

Itu cuma satu-satunya cara buat kamu gak dibully sih. Tapi kalau kamu gak ngikuti caraku pasti hidupmu di sekolah jadi gak enak.#speaker:{David}
+ [Turuti perintah {David} dan berikan bekal ke {David}]
    Ya udah, {Vid}. Aku ngikuti kamu aja.#speaker:{player}
    Nahh baguss, sekarang kamu ada bekal/jajan/uang kan. #speaker:{David}
    Kamu tinggal kasih itu ke kita sekarang aku pastiin aku gak bakal di bully di sekolah ini.#speaker:{David}
    Iyaa ini, {Vid}.#speaker:player
    {player} menyerah dan memberikan bekal/jajan/uang yang ia miliki#speaker:narrator
    -> DONE
+ [Lawan {David} dan tidak berikan bekal ke {David}]
    Itu kan ya sama aja kalau kamu malak i aku. Aku gak mau kasih bekal/jajan/uang ku ke kamu.#speaker:{player}
    Yakin itu pilihan mu ?? Guys kalian ada yang stress gak ? kek biasae aja. awokwaowka.#speaker:{David}
    Kek biasae ??Woke boss siapp. Hahahahaha.#speaker:Geng {David}
    {player} dibully oleh {David} dan geng nya#speaker:narrator
    -> DONE
-> END