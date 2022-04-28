function parseTownsToJSON(towns) {
    let townsArr = [];
    for (let town of towns.slice(1)) {
        let [empty, townName, lat, lng] =
            town.split(/\s*\|\s*/);
        let townObj = { Town: townName, Latitude:
               Math.round.Number(lat), Longitude: Number(lng) };
        townsArr.push(townObj);
    }
    console.log(JSON.stringify(townsArr));;
}