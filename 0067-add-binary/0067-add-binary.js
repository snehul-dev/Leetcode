/**
 * @param {string} a
 * @param {string} b
 * @return {string}
 */
var addBinary = function(a, b) {
  let adec = BigInt("0b"+ a)
  let bdec = BigInt("0b"+ b)
  let res = adec+bdec
  let bin = res.toString(2)
  return bin
};