VAR player = "player"
VAR David = "David"
VAR Alvin = "Alvin"
VAR Vin = "Vin"
VAR Vid = "Vid"
VAR jajan = "jajan"

->day5


=== day5 ===
{David}, saya dengar-dengar kamu suka malak barang murid-murid lain ya!#speaker:guru #score: 0 #stress: 0 #blackscreen: 0
    Hah ?? Ngga kok, Bu. Ibu dengar darimana? Itu hoax, Bu.#speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
    Hoax dari mana? Sudah keciduk gini masih saja bohong. Giliran ngga ada guru main dorong ke kolam aja.#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0
    Saya dengar dari {player}. Kenapa kamu mendorong {player} ke kolam renang?#speaker:guru #score: 0 #stress: 0 #blackscreen: 0
    Saya gak dorong, bu! Jangan main nuduh nuduh saja! Coba tanya teman-temanku yang ada di situ kemarin. Kamu jatuh sendiri ke kolam itu. Aku tau kamu ada dendam karena sempat kuejek dulu, buat itu aku minta maaf. Tapi aku ga terima difitnah gini!#speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
    {player}, apa yang dikatakan {David} itu benar? Kok kamu jadi ngarang cerita gini? Jika kamu sampai berani mbohongi guru nanti konsekuensinya berat loh ya.#speaker:guru #score: 0 #stress: 0 #blackscreen: 0
    Bu, saya ini endak bohong, yang bohong itu mereka. Aku jelas-jelas didorong sama kami ketika lagi berdebat.#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0
    Sebentar ya, {player}. Apa kamu ada buktinya? soalnya {David} ini bisa membuktikan kalau teman-temannya melihat kamu jatuh sendiri ke kolam renang.#speaker:guru #score: 0 #stress: 0 #blackscreen: 0
    Ngga ada sih, bu. Tapi mereka semua itu gengnya {David} pak, jadi ya pasti mereka bakal bohong buat ngelindungi {David}.#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0
    Ya kan aku masih bisa membawa bukti, kalau kamu malah cuma ngomong doang. Omonganmu gak bisa dibuktiin sama sekali.#speaker:{David} #score: 0 #stress: 0
    ...#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0
    Sudah gini saja, kamu minta maaf sama {David} karena sudah memfitnah dia. Kalau begitu, nanti tidak akan saya buat masalah tentang kebohongan mu. {David}, kamu setuju kan?#speaker:guru #score: 0 #stress: 0 #blackscreen: 0
    Iya, bu. Gapapa.#speaker:{David} #score: 0 #stress: 0 #blackscreen: 0
    
    {player} melihat {David} melakukan gesture mengejek di saat guru tidak melihatnya.#speaker:narrator #score: 0 #stress: 0 #blackscreen: 5
    
    +[Tidak mau meminta maaf ke {David}]
    Saya endak mau pak! Kan saya endak salah apa-apa , kenapa saya harus minta maaf?#speaker:{player} #score: 0 #stress: 0 #blackscreen: 0
    Beraninya kamu {player}! Kamu mau hukumanmu ditambahin? Minta maaf ke {David} SEKARANG!!#speaker:guru #score: 0 #stress: 0 #blackscreen: 0
    {player} pun terpaksa harus meminta maaf kepada {David}.#speaker:narrator #score: 0 #stress: 10 #blackscreen: 4
    Baiklah! <>
    +[Mau meminta maaf ke {David}]
    - <>{David}, aku mau minta ma…#speaker:{player} #score: 0 #stress: 5 #blackscreen: 0
    Ada orang yang menyela perkataan {player}#speaker:narrator #score: 0 #stress: 0 #blackscreen: 3
-> END
