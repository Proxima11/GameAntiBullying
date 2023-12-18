VAR player = "player"
VAR David = "David"
VAR Alvin = "Alvin"
VAR Vin = "Vin"
VAR Vid = "Vid"
VAR jajan = "jajan"

-> default

=== default ===

Andre sedang berjalan sendiri, buku-buku ditumpuk di tangannya. # speaker: narrator #score: 0 #stress: 0 #blackscreen: 4
(berbisik pada dirinya sendiri) Kenapa mereka selalu memilihku? # speaker: Andre #score: 0 #stress: 0 #blackscreen: 0
{player} muncul dari belakang. # speaker: narrator #score: 0 #stress: 0 #blackscreen: 2
Hei, Andre!# speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Oh, hai, {player}.# speaker: Andre #score: 0 #stress: 0 #blackscreen: 0
Ada apa? Kamu kelihatan tidak baik-baik saja. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
(menghela nafas) Hanya masalah biasa. Bullying lagi.# speaker: Andre #score: 0 #stress: 0 #blackscreen: 0
Waduh kenapa nih? Coba cerita dulu. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Andre menceritakan kejadiannya. # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
    +[{player} cepu dengan murid lain]
        Hari berikutnya. {player} bertemu dengan Andre # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
        Kamu tega sekali. Aku ga mau bertemu dengan kamu lagi !!! # speaker: Andre #score: 0 #stress: 0 #blackscreen: 0
        Andre berlari sambil menangis dan kamu merasa bersalah. # speaker: narrator #score: -50 #stress: 0 #blackscreen: 3
        ->END
    +[{player} menyemangati Andre]
        Semangat ya, Ndre. Kamu pasti bisa melalui ini. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
        Iya, {player}. Makasih ya. # speaker: Andre #score: 0 #stress: 0 #blackscreen: 0
        Andre merasa lebih tenang dari sebelumnya.  # speaker: narrator #score: 50 #stress: 0 #blackscreen: 3
        ->END
    +[{player} membantu Andre melapor ke guru]
        Andre memberanikan diri melapor ke guru dan esok harinya pembully di skors. # speaker: narrator #score: 0 #stress: 0 #blackscreen: 4
        Terima kasih, {player}. Sekarang perasaanku jadi lebih lega. # speaker: Andre #score: 0 #stress: 0 #blackscreen: 0
        Iya, Ndre. Sama-sama. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
        Uhm..{player}. Apakah kita boleh berteman. # speaker: Andre #score: 0 #stress: 0 #blackscreen: 0
        Iya, TENTU BOLEH. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
        {player} dan Andre akhirnya berteman. # speaker: narrator #score: 100 #stress: 0 #blackscreen: 3
        -> END
