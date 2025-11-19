️⃣ Single Delegate

➡ Sirf 1 method ko point karta hai.
➡ Ek delegate variable ke andar ek hi method address hota hai.

Example:
public delegate void Del();

static void A() => Console.WriteLine("A");

static void Main() {
    Del d = A;   // single method
    d();         // prints A
}


✔ Use case → Simple callbacks

-------------------------------------------------------------------------
️2. Multicast Delegate

➡ Ek delegate multiple methods ko point kar sakta hai.
➡ += use karke methods add kiye jaate hain.
➡ Call karte hi saare methods sequence me execute hote hain.

Example:
public delegate void Del();

static void A() => Console.WriteLine("A");
static void B() => Console.WriteLine("B");

static void Main() {
    Del d = A;
    d += B;   // now multicast

    d();      // prints A then B
}


✔ Use case → Events, notifications, logging
