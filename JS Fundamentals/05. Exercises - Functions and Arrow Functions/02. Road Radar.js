function roadRadar(input) {
    let speed = input[0]
    let zone = input[1]

    function getLimit(zone) {
        switch(zone) {
            case 'motorway' : return 130
            case 'interstate' : return 90
            case 'city' : return 50
            case 'residential' : return 20
        }
    }

    let limit = getLimit(zone)

    function getInfraction(speed, limit) {
        let overSpeed = speed - limit
        if(overSpeed <= 0) {
            return false
        } else {
            if(overSpeed <= 20) {
                return "speeding";
            } else if (overSpeed > 20 && overSpeed <= 40) {
                return "excessive speeding";
            } else {
                return "reckless driving";
            }
        }
    }

    let infraction = getInfraction(speed, limit)

    if(infraction) {
        console.log(infraction)
    }
}
roadRadar([21, 'residential'])