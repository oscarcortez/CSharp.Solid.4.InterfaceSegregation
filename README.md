# CSharp.Solid.4.InterfaceSegregation

codigo basado en este sitio: https://exceptionnotfound.net/simply-solid-the-interface-segregation-principle/

1. En un principio solo existe el producto Laptop y por eso se creo una interfaz producto para producto Laptop (first commit)

2. se agrego a laptop class y para eso se tuvo que agregar mas properties a la interface que en laptop se usan algunas y otras se usan en TV (no es correcto)

3. se dividio la interfaz en 3 interfaces de acuerdo a alta cohesion y single responsability, ya que IProduct estaba siendo muy generica
