VAR player = "player"
VAR David = "David"
VAR Alvin = "Alvin"
VAR Vin = "Vin"
VAR Vid = "Vid"
VAR jajan = "jajan"
-> default

=== default ===
Halo {player}. Apakah kamu disini untuk belajar berenang? # speaker: Instruktur #score: 0 #stress: 0 #blackscreen: 0
+ [Tidak, pak]
  Oke baiklah, nak. Ingat kalau berenang bisa membuatmu sehat seperti bapak. HAHAHAHA. # speaker: Instruktur #score: 0 #stress: 0 #blackscreen: 0
  h-hahaha. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
  {player} tertawa canggung # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
  ->DONE
+ [Iya, pak]
  Baiklah. Bapak akan mengajarkan teknik - teknik dasar berenang. # speaker: Instruktur #score: 0 #stress: 0 #blackscreen: 0
  Setelah beberapa saat belajar # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
  Terima kasih, pak. ternyata berenang itu mudah. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
  Iya sama - sama, nak. Berenang juga menjaga kesehatan seperti bapak. # speaker: Instruktur #score: 0 #stress: 0 #blackscreen: 0
  {player} hanya tersenyum. # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
  ->DONE
    -> END
