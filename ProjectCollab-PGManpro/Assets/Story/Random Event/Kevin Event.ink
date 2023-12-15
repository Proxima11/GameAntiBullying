VAR player = "player"
VAR David = "David"
VAR Alvin = "Alvin"
VAR Vin = "Vin"
VAR Vid = "Vid"
VAR jajan = "jajan"

-> default

=== default ===
Ada apa ini ?? # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
halo {player}, dia ini tadi mencuri barang ku. # speaker: Kevin #score: 0 #stress: 0 #blackscreen: 0
Hahh... Mencuri ?? aku cuma pinjam barang mu jangan lebay lahh. # speaker: Charles #score: 0 #stress: 0 #blackscreen: 0
ya tapi, kamu gak pernah balikin barang ku. # speaker: kevin #score: 0 #stress: 0 #blackscreen: 0
haish banyak omong kamu. # speaker: kevin #score: 0 #stress: 0 #blackscreen: 0
    + [bantu Kevin]
    CHARLES!!! balikin barangnya kevin kalau enggak aku laporin kamu ke guru  # speaker: {player} #score: 0 #stress: 0 #blackscreen: 0
    Tch... apa sih ikut-ikut aja, awas aja ya kamu.  # speaker: Charles #score: 0 #stress: 0 #blackscreen: 0
    Karena takut di laporkan guru Charles mengembalikan barang ke kevin # speaker: narrator #score: 50 #stress: 10 #blackscreen: 4
    -> END
    + [pergi]
    Wah sorry masih ada urusan, aku tinggal dulu yaa. # speaker: {player}
    Kamu pergi meninggalkan mereka # speaker: narrator #score: -20 #stress: 0 #blackscreen: 2
    -> END
    + [ikut bully kevin]
    Wah kevin, barangmu itu bagus, boleh aku pinjam juga gak ?? HAHAHAHA. # speaker: {player}
    Kamu dan Charles membully kevin bersama-sama # speaker: narrator #score: -50 #stress: -10 #blackscreen: 3 #item : 1
    -> END
