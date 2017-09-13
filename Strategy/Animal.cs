﻿namespace Patterns.Strategy
{
    public class Animal
    {
        public string Name { get; set; }

        // Instead of using an interface in a traditional way
        // we use an instance variable that is a subclass
        // of the Flys interface.

        // Animal doesn't care what flyingType does, it just
        // knows the behavior is available to its subclasses

        // This is known as Composition : Instead of inheriting
        // an ability through inheritance the class is composed
        // with Objects with the right ability

        // Composition allows you to change the capabilities of
        // objects at run time!

        public IFlys flyingType;

        // If you want to be able to change the flyingType dynamically
        public void setFlyAbility(IFlys newFlyType)
        {
            flyingType = newFlyType;
        }

        // Animal pushes off the responsibility for flying to flyingType
        public string tryToFly()
        {
            return flyingType.fly();
        }
    }
}
