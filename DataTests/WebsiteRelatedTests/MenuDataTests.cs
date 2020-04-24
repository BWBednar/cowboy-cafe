using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq;

namespace CowboyCafe.DataTests.WebsiteRelatedTests
{
    public class MenuDataTests
    {
        [Fact]
        public void EntreeMenuPropertyShouldContainExpectedEntrees()
        {
            var list = new List<IOrderItem>(Menu.Entrees);
            list.Sort((a, b) => a.ToString().CompareTo(b.ToString()));

            Assert.Collection(
                Menu.Entrees,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }

        [Fact]
        public void SideMenuPropertyShouldContainExpectedSides()
        {
            Assert.Collection(
                Menu.Sides,
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); }
                );
        }

        [Fact]
        public void DrinkMenuPropertyShouldContainExpectedSides()
        {
            Assert.Collection(
                Menu.Drinks,
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );
        }

        [Fact]
        public void CompleteMenuMenuPropertyShouldContainAllExpectedItems()
        {
            Assert.Collection(
                Menu.CompleteMenu,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );
        }
        
        [Fact]
        public void SearchMethodWithNoSearchTerms()
        {
            var list = Menu.CompleteMenu;
            Assert.Collection(
                list,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );
        }

        [Fact]
        public void SearchMethodWithSpecificSearchTermForOneItem()
        {
            var list = Menu.CompleteMenu;
            list = Menu.Search("Angry Chicken");

            Assert.Collection(
                list,
                (ac) => { Assert.IsType<AngryChicken>(ac); }
                );
        }

        [Fact]
        public void SearchMethodWithSpecificSearchTermForMultipleItems()
        {
            var list = Menu.CompleteMenu;
            list = Menu.Search("Texas");
            Assert.Collection(
                list,
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); }
                );
        }

        [Fact]
        public void FilterByCategoryMethodWithNoTypesToSearchFor()
        {
            var list = Menu.CompleteMenu;
            string[] s = new string[0];
            list = Menu.FilterByCategory(list, s);
            Assert.Collection(
                list,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );
        }

        [Fact]
        public void FilterByCategoryMethodWithOneItemToSearchFor()
        {
            var entrees = Menu.CompleteMenu;
            string[] e = new string[1] { "Entree" };
            entrees = Menu.FilterByCategory(entrees, e);
            Assert.Collection(
                entrees,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
            
            var sides = Menu.CompleteMenu;
            string[] s = new string[1] { "Side" };
            sides = Menu.FilterByCategory(sides, s);
            Assert.Collection(
                sides,
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); }
                );

            var drinks = Menu.CompleteMenu;
            string[] d = new string[1] { "Drink" };
            drinks = Menu.FilterByCategory(drinks, d);
            Assert.Collection(
                drinks,
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );
        }

        [Fact]
        public void FilterByCategoryMethodWithTwoItemsToSearchFor()
        {
            var list1 = Menu.CompleteMenu;
            string[] s1 = new string[2] { "Entree", "Side" };
            list1 = Menu.FilterByCategory(list1, s1);
            Assert.Collection(
                list1,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); }
                );


            var list2 = Menu.CompleteMenu;
            string[] s2 = new string[] { "Entree", "Drink" };
            list2 = Menu.FilterByCategory(list2, s2);
            Assert.Collection(
                list2,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );

            var list3 = Menu.CompleteMenu;
            string[] s3 = new string[] { "Side", "Drink" };
            list3 = Menu.FilterByCategory(list3, s3);
            Assert.Collection(
                list3,
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );
        }

        [Fact]
        public void FilterByCategoryMethodWithThreeItemsToSearchFor()
        {
            var list = Menu.CompleteMenu;
            string[] s = Menu.ItemTypes;
            list = Menu.FilterByCategory(list, s);
            Assert.Collection(
                list,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );
        }

        [Fact]
        public void FilterByCaloriesMethodWithNoBounds()
        {
            var list = Menu.CompleteMenu;
            list = Menu.FilterByCalories(list, null, null);
            Assert.Collection(
                list,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );
        }

        [Fact]
        public void FilterByCaloriesMethodWithUpperBounds()
        {
            var list = Menu.CompleteMenu;
            list = Menu.FilterByCalories(list, null, 200);
            Assert.Collection(
                list,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );
        }

        [Fact]
        public void FilterByCaloriesMethodWithLowerBound()
        {
            var list = Menu.CompleteMenu;
            list = Menu.FilterByCalories(list, 200, null);
            Assert.Collection(
                list,
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); }
                );
        }

        [Fact]
        public void FilterByCaloriesMethodWithUpperAndLowerBound()
        {
            var list = Menu.CompleteMenu;
            list = Menu.FilterByCalories(list, 100, 300);
            Assert.Collection(
                list,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); }
                );
        }

        [Fact]
        public void FilterByPriceMethodWithNoBounds()
        {
            var list = Menu.CompleteMenu;
            list = Menu.FilterByPrice(list, null, null);
            Assert.Collection(
                list,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );
        }

        [Fact]
        public void FilterByPriceMethodWithLowerBounds()
        {
            var list = Menu.CompleteMenu;
            list = Menu.FilterByPrice(list, 5.00, null);
            Assert.Collection(
                list,
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); }
                );
        }

        [Fact]
        public void FilterByPriceMethodWithUpperBounds()
        {
            var list = Menu.CompleteMenu;
            list = Menu.FilterByPrice(list, null, 2.00);
            Assert.Collection(
                list,
                (sbb) => { Assert.IsType<BakedBeans>(sbb); Assert.Equal("Small Baked Beans", sbb.ToString()); },
                (mbb) => { Assert.IsType<BakedBeans>(mbb); Assert.Equal("Medium Baked Beans", mbb.ToString()); },
                (lbb) => { Assert.IsType<BakedBeans>(lbb); Assert.Equal("Large Baked Beans", lbb.ToString()); },
                (sccf) => { Assert.IsType<ChiliCheeseFries>(sccf); Assert.Equal("Small Chili Cheese Fries", sccf.ToString()); },
                (scd) => { Assert.IsType<CornDodgers>(scd); Assert.Equal("Small Corn Dodgers", scd.ToString()); },
                (mcd) => { Assert.IsType<CornDodgers>(mcd); Assert.Equal("Medium Corn Dodgers", mcd.ToString()); },
                (lcd) => { Assert.IsType<CornDodgers>(lcd); Assert.Equal("Large Corn Dodgers", lcd.ToString()); },
                (spdc) => { Assert.IsType<PanDeCampo>(spdc); Assert.Equal("Small Pan de Campo", spdc.ToString()); },
                (mpdc) => { Assert.IsType<PanDeCampo>(mpdc); Assert.Equal("Medium Pan de Campo", mpdc.ToString()); },
                (lpdc) => { Assert.IsType<PanDeCampo>(lpdc); Assert.Equal("Large Pan de Campo", lpdc.ToString()); },
                (scc) => { Assert.IsType<CowboyCoffee>(scc); Assert.Equal("Small Cowboy Coffee", scc.ToString()); },
                (mcc) => { Assert.IsType<CowboyCoffee>(mcc); Assert.Equal("Medium Cowboy Coffee", mcc.ToString()); },
                (lcc) => { Assert.IsType<CowboyCoffee>(lcc); Assert.Equal("Large Cowboy Coffee", lcc.ToString()); },
                (sjs) => { Assert.IsType<JerkedSoda>(sjs); Assert.Equal("Small Cream Soda Jerked Soda", sjs.ToString()); },
                (stst) => { Assert.IsType<TexasTea>(stst); Assert.Equal("Small Texas Sweet Tea", stst.ToString()); },
                (mtst) => { Assert.IsType<TexasTea>(mtst); Assert.Equal("Medium Texas Sweet Tea", mtst.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (stpt) => { Assert.IsType<TexasTea>(stpt); Assert.Equal("Small Texas Plain Tea", stpt.ToString()); },
                (mtpt) => { Assert.IsType<TexasTea>(mtpt); Assert.Equal("Medium Texas Plain Tea", mtpt.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); },
                (sw) => { Assert.IsType<Water>(sw); Assert.Equal("Small Water", sw.ToString()); },
                (mw) => { Assert.IsType<Water>(mw); Assert.Equal("Medium Water", mw.ToString()); },
                (lw) => { Assert.IsType<Water>(lw); Assert.Equal("Large Water", lw.ToString()); }
                );
        }

        [Fact]
        public void FilterByPriceMethodWithBothLowerAndUpperBounds()
        {
            var list = Menu.CompleteMenu;
            list = Menu.FilterByPrice(list, 2.00, 5.00);
            Assert.Collection(
                list,
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (mccf) => { Assert.IsType<ChiliCheeseFries>(mccf); Assert.Equal("Medium Chili Cheese Fries", mccf.ToString()); },
                (lccf) => { Assert.IsType<ChiliCheeseFries>(lccf); Assert.Equal("Large Chili Cheese Fries", lccf.ToString()); },
                (mjs) => { Assert.IsType<JerkedSoda>(mjs); Assert.Equal("Medium Cream Soda Jerked Soda", mjs.ToString()); },
                (ljs) => { Assert.IsType<JerkedSoda>(ljs); Assert.Equal("Large Cream Soda Jerked Soda", ljs.ToString()); },
                (ltst) => { Assert.IsType<TexasTea>(ltst); Assert.Equal("Large Texas Sweet Tea", ltst.ToString()); },
                (ltpt) => { Assert.IsType<TexasTea>(ltpt); Assert.Equal("Large Texas Plain Tea", ltpt.ToString()); }
                );
        }
    }
}
