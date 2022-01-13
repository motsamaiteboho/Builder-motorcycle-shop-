using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_motorcycle_shop_
{
        public enum RidingPosition
        {
            Standing, Upright, Relaxed, SemiSporty, Sporty, VerySporty
        } //RidingPosition

        public enum ScreenType
        {
            None, Low, Medium, High
        } //ScreenType

        public enum FuelCapacity
        {
            Low, Medium, High, VeryHigh
        } //FuelCapacity

        public enum CrashProtection
        {
            None, Some, Much
        } //CrashProtection

        public enum SeatHeight
        {
            VeryLow, Low, Medium, High, VeryHigh
        } //SeatHeight

        public enum Rim
        {
            Cast, Spokes
        } //Rim

        public enum GroundClearance
        {
            Low, Medium, High, VeryHigh
        } //GroundClearance

        public enum SuspensionTravel
        {
            Short, Medium, Long, VeryLong
        } //SuspensionTravel

        public enum Weight
        {
            Light, Medium, Heavy, VeryHeavy
        } //Weight

        public enum Pillion
        {
            None, Small, Yes
        } //Pillion

        public enum WindProtection
        {
            None, Minimal, Standard, Good
        } //WindProtection

        public enum Instruments
        {
            Minimal, Standard, AllTheToys
        } //Instruments

        public enum BodyType
        {
            Sedan, SUV
        } //BodyType
}
