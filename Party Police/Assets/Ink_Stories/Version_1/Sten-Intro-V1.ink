->Information_1_1
=== Intro ===
You there! 
You’re the one who washed up on the beach.
You should leave if you know what’s good for you!
There are dark forces at work in this town…
Someone has upset the spirits!
*[Hello there. You must be the Elder I have heard about.]
    I am Sten, yes. The elder. Mark my words… dark forces are at play in this town. They’ll see… they’ll all see!
    ->DONE
*[Get away from me old man! I don’t believe in all that spiritual stuff!]
    Heed my warnings! Dark forces! You’ll see soon enough!
    ->DONE
    
=== Information_1_1 ===
Oh hello again... what do you want?
*[Look, forget the spirits. Where have the children gone?]
    Forget the spirits!? Do not let the Fossegrim hear that!
    **[Not this again...] -> Information_1_2
*[I was hoping you could tell me if you've seen anything weird lately.]
    Seen anything? No... but I have felt something. I have felt the presence of upset spirits! The Fossegrim...
    **[Not this again...] -> Information_1_2
*[I'm Revna. Could you tell me more about the "upset spirits"?]
    Oh so you believe me? You are the only one... but I know about the Fossegrim.
    **[Fossegrim?] -> Information_1_2
=== Information_1_2
Heed my warnings! We have forgotten our sacred oaths to the spirits of the forest!
    +[Who is the Fossegrim?]
        Why, the forest spirit! There is also Odin, and Loki, and Thor, and... 
            ++[Okay! Thank you for that rant...]
            -> Information_1_2
    +[What do you do in town?]
        What do I do? I praise the spirits of course! I keep the town safe! I...
            ++[Does that include sacrificing children!?]
                Well... if Odin were to command me...
                +++[I guess that's not enough to accuse you of anything.] -> Information_1_2
    +[Is there anyone I should investigate?]
        Hmm. Well I never did trust the Cattle Herder, Gro, much. And Harold seems to have it out for me. Though he seems to like children.
        ++[The Cattle Herder, Gro. I'll have a talk with them.] -> Information_1_2
    +[I don't have anything to ask you right now.] -> DONE