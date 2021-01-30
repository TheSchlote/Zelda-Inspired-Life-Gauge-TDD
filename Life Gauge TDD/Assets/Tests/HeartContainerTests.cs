using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using NUnit.Framework;

public class HeartContainerTests
{
    public class TheReplenishMethod
    {
        protected Image Target;

        [SetUp]
        public void BeforeEveryTest()
        {
            Target = An.Image();
        }

        [Test]
        public void _0_Sets_Image_With_0_Fill_To_0_Fill()
        {
            ((HeartContainer)A.HeartContainer().With(A.Heart().With(Target))).Replenish(0);

            Assert.AreEqual(0, Target.fillAmount);
        }

        [Test]
        public void _1_Sets_Image_With_0_Fill_To_25_Percent_Fill()
        {
            ((HeartContainer)A.HeartContainer().With(A.Heart().With(Target))).Replenish(1);

            Assert.AreEqual(0.25f, Target.fillAmount);
        }

        [Test]
        public void _Empty_Hearts_Are_Replenished()
        {
            ((HeartContainer)A.HeartContainer()
                .With(
                        A.Heart().With(An.Image().WithFillAmount(1)),
                        A.Heart().With(Target))).Replenish(1);

            Assert.AreEqual(0.25f, Target.fillAmount);
        }

        [Test]
        public void _Hearts_Are_Replenished_In_Order()
        {
            ((HeartContainer)A.HeartContainer()
                .With(A.Heart(), A.Heart().With(Target))).Replenish(1);

            Assert.AreEqual(0, Target.fillAmount);
        }

        public class HeartContainer
        {
            private readonly List<Heart> _hearts;

            public HeartContainer(List<Heart> hearts)
            {
                _hearts = hearts;
            }

            public void Replenish(int numberOfHeartPieces)
            {
                var numberOfHeartPiecesRemaining = numberOfHeartPieces;
                foreach(var heart in _hearts)
                {
                    numberOfHeartPiecesRemaining -= Heart.HeartPiecesPerHeart - heart.CurrentNumberOfHeartPieces;
                    heart.Replenish(numberOfHeartPieces);
                    if (numberOfHeartPiecesRemaining <= 0) break;
                }
                
            }
        }
    }
}
