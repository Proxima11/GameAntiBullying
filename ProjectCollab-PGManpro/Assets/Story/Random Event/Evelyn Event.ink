VAR player = "player"
VAR David = "David"
VAR Alvin = "Alvin"
VAR Vin = "Vin"
VAR Vid = "Vid"
VAR jajan = "jajan"

-> default

=== default ===

(terdengar suara dari kejauhan) Haduhh pusingg. # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3 
{player} menghampiri suara tersebut. # speaker: narrator #score: 0 #stress: 0 #blackscreen: 3
Kamu kenapa? # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Aku tidak bisa mengerjakan tugas ini. Deadline nya juga udah mepet lagi. # speaker: Evelyn #score: 0 #stress: 0 #blackscreen: 0
+[Bersikap cuek dan tidak membantu]
Oh, begitu toh. A-aku juga ga bisa membantu. Ada sesuatu yang harus aku lakukan. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Oh, oke. # speaker: Evelyn #score: -50 #stress: 0 #blackscreen: 0
->END
+[Membantu Evelyn]
Sini aku bantu, Ev. Tugas apa ini? # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Tugas matematika. Terima kasih ya. Kamu pinter banget deh. # speaker: Evelyn #score: 0 #stress: 0 #blackscreen: 0
hahaha... # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Hari - hari seterusnya # speaker: narrator #score: 0 #stress: 0 #blackscreen: 2
(dengan niat jahat) {player}, tolong bantu kerjain tugas aku lagi donggg... # speaker: Evelyn #score: 0 #stress: 0 #blackscreen: 0
++[Tidak mau]
Kamu selalu manfaatin aku cuman buat kerjain tugasmu. Aku ga mau lagi. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
APA? Aku akan laporin ini ke papaku. # speaker: Evelyn #score: 0 #stress: 0 #blackscreen: 0
Laporin saja. Aku cuman tidak mau dimanfaatkan orang lain. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Player lepas dari jeratan tugas Evelyn dan menjalani hari-hari sekolah dengan damai.  # speaker: narrator #score: 50 #stress: 5 #blackscreen: 5
->DONE
++[Membantu]
Ya.. tetapi kenapa kamu minta bantuan ku terus. # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
Habisnya kamu pinter jadi kamu aja yang kerjain tugasku. (bersikap cuek) # speaker: Evelyn #score: 0 #stress: 0 #blackscreen: 0
...
Player setiap hari dipaksa mengerjakan tugas Evelyn.  # speaker: narrator #score: -20 #stress: 10 #blackscreen: 4
->DONE

-> END
