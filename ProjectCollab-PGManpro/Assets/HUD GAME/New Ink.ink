halooooooooooooooooooooooooooooooooooooooooooooooooo # speaker: David
haloooooooooooooooooooooooooooooooooooooooooooooooooooooo, too # speaker: Alvin

David Menanyakan sesuatu ke Alvin # speaker: narrator
asdfgas dasfgadsg # speaker: narrator
asdfsdfadsf asdgasgdg # speaker: narrator
->main
=== main ===

Which pokemon do you choose? #speaker : David
    + [Charmander]
        are you sure ? 
            * * [yes]
                -> chosen("Charmander")
            * *  [no] 
                -> main 
    + [Bulbasaur]
        -> chosen("Bulbasaur")
        
=== chosen(pokemon) ===
You chose {pokemon}!
-> END
