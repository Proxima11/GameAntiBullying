haloo # speaker: David
haloo, too # speaker: Alvin
->main
=== main ===

Which pokemon do you choose? #speaker : David
    + [Charmander]
        are you sure ? 
            * * yes
                -> chosen("Charmander")
            * *  no 
                -> main 
    + [Bulbasaur]
        -> chosen("Bulbasaur")
        
=== chosen(pokemon) ===
You chose {pokemon}!
-> END
