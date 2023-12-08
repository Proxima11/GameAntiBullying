VAR Player = ""
~ Player = "{~Halo! Salam kenal|Hai, aku anak baru disini salam kenal ya}"

VAR Teman = ""
~ Teman = "{~Hai, salam kenal|Oo kamu anak baru itu, salam kenal juga}"

-> dialog("Budi")

=== dialog(player) ===
{Player}#speaker:{player}
{Teman}#speaker: Teman
-> DONE