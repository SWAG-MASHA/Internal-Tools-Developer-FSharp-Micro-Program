module Haikunator
    open System


    let adjectives = [|        
        "autumn"; "hidden"; "bitter"; "misty"; "silent"; "empty"; "dry"; "dark"; "summer"
        "icy"; "delicate"; "quiet"; "white"; "cool"; "spring"; "winter"; "patient"
        "twilight"; "dawn"; "crimson"; "wispy"; "weathered"; "blue"; "billowing"
        "broken"; "cold"; "damp"; "falling"; "frosty"; "green"; "long"; "late"; "lingering"
        "bold"; "little"; "morning"; "muddy"; "old"; "red"; "rough"; "still"; "small"
        "sparkling"; "throbbing"; "shy"; "wandering"; "withered"; "wild"; "black"
        "young"; "holy"; "solitary"; "fragrant"; "aged"; "snowy"; "proud"; "floral"
        "restless"; "divine"; "polished"; "ancient"; "purple"; "lively"; "nameless"
    |]

    let nouns = [|
        "waterfall"; "river"; "breeze"; "moon"; "rain"; "wind"; "sea"; "morning"
        "snow"; "lake"; "sunset"; "pine"; "shadow"; "leaf"; "dawn"; "glitter"; "forest"
        "hill"; "cloud"; "meadow"; "sun"; "glade"; "bird"; "brook"; "butterfly"
        "bush"; "dew"; "dust"; "field"; "fire"; "flower"; "firefly"; "feather"; "grass"
        "haze"; "mountain"; "night"; "pond"; "darkness"; "snowflake"; "silence"
        "sound"; "sky"; "shape"; "surf"; "thunder"; "violet"; "water"; "wildflower"
        "wave"; "water"; "resonance"; "sun"; "wood"; "dream"; "cherry"; "tree"; "fog"
        "frost"; "voice"; "paper"; "frog"; "smoke"; "star"
    |]

    let randomElement (elements : 'a[]) (rnd: Random) =
        elements.[rnd.Next() % elements.Length]

    let simpleGenerate rnd = 
        let randomAdjective = randomElement adjectives rnd
        let randomNoun = randomElement nouns rnd
        let randomNumber = rnd.Next() % 9999
        sprintf "%s-%s-%d" randomAdjective randomNoun randomNumber

    let generateRandomNumberOfRandomHaikus =
        let rnd = Random()
        let randomNumberOfElements = rnd.Next() % 45 + 15
        [for i in 0 .. randomNumberOfElements -> simpleGenerate rnd]  