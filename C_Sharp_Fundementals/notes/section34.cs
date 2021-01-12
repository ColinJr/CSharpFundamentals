/*Enums are a data type
 * 
 * Present a set of constant name/value pairs
 */
const int RegularAirMail = 1;
const int RegusteredAirMail = 2;
const int Express = 3;
// While the above works for defining a constant of shipping methods, the situation is better suited to an enum

public enum ShippingMethod
{
    RegularAirMail = 1,
    RegisteredAirMail = 2,
    Express = 3;
}

/* In this we use the more organized enum to contain all of the defined value pairs neatly
 * use them when you have values you know won't change, like month days, days, colors, card decks and so on
 */