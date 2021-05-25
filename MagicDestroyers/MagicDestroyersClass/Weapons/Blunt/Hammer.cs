using System;
namespace MagicDestroyersClass.Weapons.Blunt
{
    public class Hammer : Weapon
    {
        public Hammer()
        {
            base.Damage = 10;
        }
        public void Stun()
        {
            throw new NotImplementedException();
        }
    }
}
