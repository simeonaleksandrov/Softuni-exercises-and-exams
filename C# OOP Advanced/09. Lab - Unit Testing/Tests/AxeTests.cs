﻿namespace SkeletonTests
{
    using NUnit.Framework;
    using System;

    public class Tests
    {
        [Test]

        public void AxeLossesDurabilityAfterAttack()
        {
            Axe axe = new Axe(10, 10);
            Dummy dummy = new Dummy(10, 10);

            axe.Attack(dummy);

            Assert.AreEqual(9, axe.DurabilityPoints);
        }

        [Test]
        public void AxeAttackWithBrokenAxeShouldThrow()
        {
            Axe axe = new Axe(10, 0);
            Dummy dummy = new Dummy(10, 10);

            Assert.That(() => axe.Attack(dummy), Throws.InvalidOperationException.With.Message.EqualTo("Axe is broken."));
        }
    }
}