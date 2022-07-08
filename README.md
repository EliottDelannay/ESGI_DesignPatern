# ESGI_DesignPattern

# Pattern de conception
Les patterns de conception répondent à des problématiques lié à la POO

![AbstractFactory](AbstractFactory.png)
<br>

**Catalogue** est un classe pouvant fabriquer des véhicules et contient des objets de type Scooter/Automobile.

**Scooter** est une classe abstraite qui est hérité par 2 classes qui vont la spécialiser.

![PatternBuilder](PatternBuilder.png)

**ClientVéhicule** est une classe composé de vendeur, constructeur liasse.
ConstructeurLiasseVéhicule est composé de liasse.

le pattern permet aux client de construires les objets qui va compléter ces données. La construction se fait à partir de méthodes qui va instancier les objets et les remplirs. La complétion de l'objet ClientVéhicule se fait graduellement en descendant dans les classe qui le constituent. Ex : **ClientVéhicule** construit un **vendeur** qui construit un **ConstructeurLiasseVéhicule** qui va construire une **liasse**.

![FactoryMethod](FactoryMethod.png)
<br> Le pattern FactoryMethode consiste à avoir des méthodes construisant un objet.

<br> **Singleton** 
<br> Le pattern Singleton consiste à n'avoir qu'une seule instance d'un objet, cela permet d'économiser de la mémoire.

<br> **Prototype**
<br> Le pattern permet de créer des objets à partir d'autre objets appelé prototype avec une méthode clone qui retour un objet identique

# Pattern de structure ou de structuration

Les patterns de structuration permettent l'indépendance de l'interface d'un objet et son implémentation. <br>
Les interfaces permettent d'encapsuler la composition des objets. <br>

Exercice : composition vs héritage en C# <br>

La composition se base sur un classe qui récupère des méthodes overrides qui ont un traitement proche avec entrées/sorties proches. <br>

L'héritage se base sur une classe fille qui récupère des méthodes et des attributs d'une classe mère et qui en rajoute pour ce spécialiser. <br>