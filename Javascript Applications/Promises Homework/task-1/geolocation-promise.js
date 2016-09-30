(function () {
    let locationElement = document.getElementById('location-element');

    let locationPromise = new Promise((resolve, reject) => {
        navigator.geolocation.getCurrentPosition((pos) => {
            resolve(pos);
            return pos;            
        });

    });

    function parsePosition(pos) {
        return {
            lat: pos.coords.latitude,
            long: pos.coords.longitude
        };
    }

    function displayMap(pos) {
        let src = `http://maps.googleapis.com/maps/api/staticmap?center=${pos.lat},${pos.long}&zoom=15&size=500x500&sensor=false`;
        let map = document.createElement('img');

        map.setAttribute('src', src);

        locationElement.appendChild(map);
    }

    locationPromise
        .then(parsePosition)
        .then(displayMap)
        .catch();
} ());

