VAR player = "player"
VAR David = "David"
VAR Alvin = "Alvin"
-> day1

=== day1 ===
Haloo {player}, aku {Alvin}. Nanti aku yang bakal kenalin sekolah ini ke kamu. # speaker: {Alvin}
    + [Halo juga, {Alvin}. Makasih ya udah mau bantu aku.]
        Okeii, kalo gitu langsung aja kita keliling sekolah ini. Ayo ikut aku. # speaker: {Alvin}

    + [Loh, bukannya guru nyuruh {David} tadi?]
        {David} sibuk soalnya tadi, jadi aku gantiin {David} buat ngenalin sekolah ke kamu. # speaker: {Alvin}
            Ohh gituu, okayy. # speaker: {player}
                Okee, ayo ikut aku. # speaker: {Alvin}

-  Saat {Alvin} mengenalkan player lingkungan sekolah... # speaker: narrator
    -> END
