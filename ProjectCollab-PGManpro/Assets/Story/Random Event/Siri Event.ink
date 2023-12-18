VAR player = "player"
VAR David = "David"
VAR Alvin = "Alvin"
VAR Vin = "Vin"
VAR Vid = "Vid"
VAR jajan = "jajan"

-> default

=== default ===
{player} bertemu dengan teman lamanya # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
{player}, rupanya kamu pindah kesini. Ayo bermain bersama. # speaker: Siri #score: 0 #stress: 0 #blackscreen: 0
Aduh, Sir. Aku mau belajar dulu. Nanti sepulang sekolah aja ya. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Siri memaksa {player} pada waktu pelajaran. # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
+[bermain bersama]
Ya sudah, ayo bermain. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Yey. Ayo. # speaker: Siri #score: 0 #stress: 0 #blackscreen: 0
{player} bermain diam-diam dan lupa dengan pelajarannya. # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
Keesokannya # speaker: narrator #score: 0 #stress: 0 #blackscreen: 2
Ayo bermain lagi. # speaker: Siri #score: 0 #stress: 0 #blackscreen: 0
++[bermain lagi]
{player} akhirnya kecanduan dan lupa pelajaran. # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
Aduh nilaiku jadi jelek semua. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Ayo main lagi, {player}. # speaker: Siri #score: 0 #stress: 0 #blackscreen: 0
INI SEMUA GARA - GARA KAMU NILAIKU jelek !!! # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
akhirnya {player} bermusuhan dengan Siri # speaker: narrator #score: 0 #stress: -15 #blackscreen: 3
->END
++[menolak]
Siri akhinya ngambek dengan {player} # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
kenapa sih kamu? Kemarin mau bermain sama aku, sekarang ngga. # speaker: Siri #score: 0 #stress: 0 #blackscreen: 0
Sir, waktu pelajaran kita harus fokus. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Ngga mau tau pokoknya kita musuhan. # speaker: Siri #score: 0 #stress: 0 #blackscreen: 0
{player} menyisihkan waktunya saat istirahat walaupun telat masuk kelas selanjutnya. # speaker: narrator #score: 50 #stress: 5 #blackscreen: 5
->END
->DONE
+[tetap mengikuti pelajaran]
Siri akhinya ngambek dengan {player} # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
Sir, kamu gpp ta? # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
HMPH, kamu ngga mau main dengan Aku.  # speaker: Siri #score: 0 #stress: 0 #blackscreen: 0
{player} memberikan penjelasan dan Siri mengerti. {player} dan Siri bermain sepulang sekolah.# speaker: narrator #score: 100 #stress: -5 #blackscreen: 5
->DONE
    -> END
