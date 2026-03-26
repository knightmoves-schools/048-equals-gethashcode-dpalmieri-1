namespace Tests;

using knightmoves;
using Xunit;

public class AutogradingTest
{
    [Fact]
    public void Should_Determine_That_Two_Instances_With_The_Same_Make_And_Model_Are_Equal(){
      Car first = new Car("one", "two");
      Car second = new Car("one", "two");

      Assert.True(first.Equals(second));
    }

    [Fact]
    public void Should_Produce_A_HashCode_Containing_The_Make_And_Model(){
      Car first = new Car("one", "two");

      var hashCodeV1 = HashCode.Combine(first.Make, first.Model);
      var hashCodeV2 = HashCode.Combine(first.Model, first.Make);

      Assert.True(first.GetHashCode() == hashCodeV1 || first.GetHashCode() == hashCodeV2);
    }
}