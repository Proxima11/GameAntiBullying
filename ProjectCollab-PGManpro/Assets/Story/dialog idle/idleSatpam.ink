-> default("Player")

=== default(player) ===
Halo, nak. Apa yang kamu lakukan disini? #speaker: Satpam
+ [hanya menyapa]
  Halo, pak. Saya cuman jalan - jalan disini. #speaker: player
  Baiklah, nak. Kalau ada sesuatu yang berbahayaa bilang bapak ya. #speaker: Satpam
  Terima kasih, pak. #speaker: player
  ->DONE
+ [ingin keluar sekolah]
  APA?!? kamu ingin keluar sekolah? #speaker: Satpam
  Iya, pak. Saya mau kabur dari sekolah. #speaker: player
  Tidak bisa, nak. Masuk kembali ke sekolah. #speaker: Satpam
  Player dimarahi oleh pak satpam. #speaker: narrator
  ->DONE
    -> END
