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

