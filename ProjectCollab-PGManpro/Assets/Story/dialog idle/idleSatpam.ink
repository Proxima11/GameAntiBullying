VAR player = "player"
VAR David = "David"
VAR Alvin = "Alvin"
VAR Vin = "Vin"
VAR Vid = "Vid"
VAR jajan = "jajan"
-> default

=== default ===
Halo, nak. Apa yang kamu lakukan disini? #speaker: Satpam #score: 0 #stress: 0 #blackscreen: 0
+ [hanya menyapa]
  Halo, pak. Saya cuman jalan - jalan disini. #speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
  Baiklah, nak. Kalau ada sesuatu yang berbahayaa bilang bapak ya. #speaker: Satpam #score: 0 #stress: 0 #blackscreen: 0
  Terima kasih, pak. #speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
  ->DONE
+ [ingin keluar sekolah]
  APA?!? kamu ingin keluar sekolah? #speaker: Satpam #score: 0 #stress: 0 #blackscreen: 0
  Iya, pak. Saya mau kabur dari sekolah. #speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
  Tidak bisa, nak. Masuk kembali ke sekolah. #speaker: Satpam #score: 0 #stress: 0 #blackscreen: 0
  {player} dimarahi oleh pak satpam. #speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
  ->DONE
    -> END
