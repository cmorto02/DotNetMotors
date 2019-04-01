using System;
using Xunit;
using DotNetMotors;
using DotNetMotors.Classes;

namespace DotNetMotorsTests
{
    public class UnitTest1
    {
        [Fact]
        public void UndersRequireALiscense()
        {
            Under under = new Under();

            Assert.True(under.RequiresLiscense);
        }
        [Fact]
        public void UndersDontRequireALiscense()
        {
            Under under = new Under();
            under.RequiresLiscense = false;

            Assert.False(under.RequiresLiscense);
        }
        [Fact]
        public void UndersDontCarryPeople()
        {
            Under under = new Under();

            Assert.False(under.CarriesPeople);
        }
        [Fact]
        public void UndersDoCarryPeople()
        {
            Under under = new Under();
            under.CarriesPeople = true;

            Assert.True(under.CarriesPeople);
        }
        [Fact]
        public void UndersHave20Wheeles()
        {
            Under under = new Under();

            Assert.Equal(20, under.NumberOfWheeles);
        }
        [Fact]
        public void UndersHave10Wheeles()
        {
            Under under = new Under();
            under.NumberOfWheeles = 10;

            Assert.Equal(10, under.NumberOfWheeles);
        }
        [Fact]
        public void UndersHave2Doors()
        {
            Under under = new Under();

            Assert.Equal(2, under.NumberOfDoors);
        }
        [Fact]
        public void UndersHave4Doors()
        {
            Under under = new Under();
            under.NumberOfDoors = 4;

            Assert.Equal(4, under.NumberOfDoors);
        }
        [Fact]
        public void TracksHave40Wheeles()
        {
            Tracks tracks = new Tracks();

            Assert.Equal(40, tracks.NumberOfWheeles);
        }
        [Fact]
        public void TracksHave4Wheeles()
        {
            Tracks tracks = new Tracks();
            tracks.NumberOfWheeles = 4;

            Assert.Equal(4, tracks.NumberOfWheeles);
        }
        [Fact]
        public void TracksSpeedLimit40()
        {
            Tracks tracks = new Tracks();
            tracks.Speed = 40;

            Assert.Equal(40, tracks.Speed);
        }
        [Fact]
        public void TracksSpeedLimit80()
        {
            Tracks tracks = new Tracks();
            tracks.Speed = 80;

            Assert.Equal(80, tracks.Speed);
        }
        [Fact]
        public void TracksCarryPeople()
        {
            Tracks tracks = new Tracks();

            Assert.True(tracks.CarriesPeople);
        }
        [Fact]
        public void TracksDontCarryPeople()
        {
            Tracks tracks = new Tracks();
            tracks.CarriesPeople = false;

            Assert.False(tracks.CarriesPeople);
        }
        [Fact]
        public void TracksRequireLiscense()
        {
            Tracks tracks = new Tracks();

            Assert.True(tracks.RequiresLiscense);
        }
        [Fact]
        public void TracksDontRequireLiscense()
        {
            Tracks tracks = new Tracks();
            tracks.RequiresLiscense = false;

            Assert.False(tracks.RequiresLiscense);
        }
        [Fact]
        public void PropsRequireLiscense()
        {
            Prop prop = new Prop();

            Assert.True(prop.RequiresLiscense);
        }
        [Fact]
        public void PropsDontRequireLiscense()
        {
            Prop prop = new Prop();
            prop.RequiresLiscense = false;

            Assert.False(prop.RequiresLiscense);
        }
        [Fact]
        public void NoTracksCarryPeople()
        {
            NoTracks noTracks = new NoTracks();

            Assert.True(noTracks.CarriesPeople);
        }
        [Fact]
        public void NoTracksDontCarryPeople()
        {
            NoTracks noTracks = new NoTracks();
            noTracks.CarriesPeople = false;

            Assert.False(noTracks.CarriesPeople);
        }
        [Fact]
        public void NoTracksRequireLiscense()
        {
            NoTracks NoTracks = new NoTracks();

            Assert.True(NoTracks.RequiresLiscense);
        }
        [Fact]
        public void NoTracksDontRequireLiscense()
        {
            NoTracks noTracks = new NoTracks();
            noTracks.RequiresLiscense = false;

            Assert.False(noTracks.RequiresLiscense);
        }
        [Fact]
        public void JetsRequireLiscense()
        {
            Jet jet = new Jet();

            Assert.True(jet.RequiresLiscense);
        }
        [Fact]
        public void JetsDontRequireLiscense()
        {
            Jet jet = new Jet();
            jet.RequiresLiscense = false;

            Assert.False(jet.RequiresLiscense);
        }
        [Fact]
        public void Morethan1JetIsAFlock()
        {
            Jet jet = new Jet();
            bool truth = jet.IsAFlock(4);

            Assert.False(truth);
        }

        //the below demonstrate inherited behaviors and interfaces

        [Fact]
        public void JetInheritedInterfaceFromAir()
        {
            Jet jet = new Jet();
            bool truth = jet.NotClaustrophobic();

            Assert.True(truth);
        }
        [Fact]
        public void JetInheritedVirtualPropertyFromAir()
        {
            Jet jet = new Jet();
            bool truth = jet.RequiresCaptain;

            Assert.True(truth);
        }
        [Fact]
        public void PropInheritedInterfaceFromAir()
        {
            Prop prop = new Prop();
            bool truth = prop.NotClaustrophobic();

            Assert.True(truth);
        }
        [Fact]
        public void PropInheritedVirtualPropertyFromAir()
        {
            Prop prop = new Prop();
            bool truth = prop.RequiresCaptain;

            Assert.True(truth);
        }
        [Fact]
        public void NoTracksInheritedDoors()
        {
            NoTracks noTracks = new NoTracks();
            int inherited = noTracks.NumberOfDoors;

            Assert.Equal(4, inherited);
        }
        [Fact]
        public void NoTracksInheritedWheeles()
        {
            NoTracks noTracks = new NoTracks();
            int inherited = noTracks.NumberOfWheeles;

            Assert.Equal(4, inherited);
        }
        [Fact]
        public void TracksUseInterface()
        {
            Tracks tracks = new Tracks();
            bool truth = tracks.CertRequired();

            Assert.True(truth);
        }
        [Fact]
        public void JetFlockOverwrittenToFalsAndIsAGaggle()
        {
            Jet jet = new Jet();
            bool truth = jet.IsAFlock(4);

            Assert.False(truth);
        }
    }
}
