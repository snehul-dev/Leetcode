/**
 * @param {number} mass
 * @param {number[]} asteroids
 * @return {boolean}
 */
var asteroidsDestroyed = function(mass, asteroids) {
    let sorted = asteroids.sort((a,b)=>a-b)

    for(let ast of sorted){
        if(mass>=ast){
            mass+=ast
        }else{
            return false
        }
    }
    return true
    
};