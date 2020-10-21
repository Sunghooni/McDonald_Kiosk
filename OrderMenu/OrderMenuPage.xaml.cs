﻿using McDonald_Kiosk.OrderMenu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace McDonald_Kiosk
{
    /// <summary>
    /// Page1.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class OrderMenuPage : Page
    {
        public OrderMenuPage()
        {
            InitializeComponent();
            lbMenus.ItemsSource = lstMenu.Where(x => x.category == Category.BUGER).ToList();
            //lvAddedMenu.
        }

        //public class MenuList
        //{
        //    public Category category { get; set; }
        //    public string ImgPath { get; set; }
        //    public string name { get; set; }
        //}


        private void lbCategory_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (lbCategory.SelectedIndex == -1) return;
            Category category = (Category)lbCategory.SelectedIndex;
            lbMenus.ItemsSource = lstMenu.Where(x => x.category == category).ToList();
        }
            
        private List<OrderMenu.Food> lstMenu = new List<OrderMenu.Food>()
        {
            new OrderMenu.Food() { category = Category.BUGER, name="빅 맥", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1583727841393.png", price = 4900},
            new OrderMenu.Food() { category = Category.BUGER, name="케이준 맥치킨", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1600413692852.png", price = 5100 },
            new OrderMenu.Food() { category = Category.BUGER, name="맥스파이시 상하이 버거", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1583728339451.png", price = 4600 },
            new OrderMenu.Food() { category = Category.BUGER, name="1995 버거", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1599119588089.png", price = 5500 },
            new OrderMenu.Food() { category = Category.BUGER, name="맥치킨 모짜렐라", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1583727633823.png", price = 4700 },
            new OrderMenu.Food() { category = Category.BUGER, name="더블 1995 버거", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1583727223345.png", price = 7000 },
            new OrderMenu.Food() { category = Category.BUGER, name="더블 불고기 버거", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1583727299888.png", price = 4500 },
            new OrderMenu.Food() { category = Category.BUGER, name="에그 불고기 버거", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1599100021723.png", price = 4500 },
            new OrderMenu.Food() { category = Category.BUGER, name="슈비 버거", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1583727896884.png" , price = 5500},
            new OrderMenu.Food() { category = Category.BUGER, name="베이컨 토마토 디럭스", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1583727690227.png", price = 5100 },
            new OrderMenu.Food() { category = Category.BUGER, name="더블 쿼터파운더 치즈", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1583727487454.png", price = 6700 },
            new OrderMenu.Food() { category = Category.BUGER, name="에그 맥머핀", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201901290308474630.png", price = 2500 },
            new OrderMenu.Food() { category = Category.BUGER, name="베이컨 토마토 머핀", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201901290308359530.png", price = 3200 },
            new OrderMenu.Food() { category = Category.BUGER, name="소세지 에그 맥머핀", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201903190244458360.png", price = 3000 },

            new OrderMenu.Food() { category = Category.SIDE, name="타로 파이", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1600755612822.png", price = 1000 },
            new OrderMenu.Food() { category = Category.SIDE, name="웨지 후라이", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1599099116070.png", price = 2100 },
            new OrderMenu.Food() { category = Category.SIDE, name="맥스파이시 상하이 치킨 스낵랩", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201902080435011620.png", price = 2600 },
            new OrderMenu.Food() { category = Category.SIDE, name="애플 파이", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201902040342215990.png", price = 1000 },
            new OrderMenu.Food() { category = Category.SIDE, name="골든 모짜렐라 치즈스틱", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201902080435496530.png", price = 2600 },
            new OrderMenu.Food() { category = Category.SIDE, name="후렌치 후라이", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201902070318045120.png", price = 1700 },
            new OrderMenu.Food() { category = Category.SIDE, name="맥스파이시 치킨 텐더", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201903120346584950.png", price = 8800 },
            new OrderMenu.Food() { category = Category.SIDE, name="해쉬 브라운", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1563759767701.jpg", price = 1000 },
            new OrderMenu.Food() { category = Category.SIDE, name="바나나 오레오 맥플러리", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1590473591953.png", price = 2500 },
            new OrderMenu.Food() { category = Category.SIDE, name="오레오 맥플러리", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201905140116054120.png", price = 2500 },
            new OrderMenu.Food() { category = Category.SIDE, name="딸기 오레오 맥플러리", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201905140116378240.png", price = 2500 },
            new OrderMenu.Food() { category = Category.SIDE, name="초코 선데이 아이스크림", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201901290248295110.png", price = 1500 }
            ,
            new OrderMenu.Food() { category = Category.DRINK, name="배 칠러", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1584411193442.png", price = 2500},
            new OrderMenu.Food() { category = Category.DRINK, name="자두 칠러", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201901290217064420.png", price = 2500},
            new OrderMenu.Food() { category = Category.DRINK, name="카페 라떼", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201901290234398270.png", price = 2500},
            new OrderMenu.Food() { category = Category.DRINK, name="디카페인 카페 라떼", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1577432576871.jpg", price = 2500},
            new OrderMenu.Food() { category = Category.DRINK, name="카푸치노", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201901290235239890.png", price = 2500},
            new OrderMenu.Food() { category = Category.DRINK, name="아메리카노", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201901290232543290.png", price = 2000},
            new OrderMenu.Food() { category = Category.DRINK, name="에스프레소", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201902121106138080.png", price = 2100},
            new OrderMenu.Food() { category = Category.DRINK, name="프리미엄 로스트 원두 커피", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201901290228358090.png", price = 2100},
            new OrderMenu.Food() { category = Category.DRINK, name="바닐라 쉐이크", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201901290255488970.png", price = 3100},
            new OrderMenu.Food() { category = Category.DRINK, name="딸기 쉐이크", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201901290257347040.png", price = 3100},
            new OrderMenu.Food() { category = Category.DRINK, name="초코 쉐이크", imgPath="https://www.mcdonalds.co.kr/uploadFolder/product/prol_201901290257444640.png", price = 3100},
            new OrderMenu.Food() { category = Category.DRINK, name="코카 콜라", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1583889953745.png", price = 1600},
            new OrderMenu.Food() { category = Category.DRINK, name="스프라이트", imgPath="https://www.mcdonalds.co.kr/upload/product/pcList/1583889827271.png", price = 1600}
        };

        private void lbMenus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lbMenus.SelectedIndex == -1) return;
            Food food = lbMenus.SelectedItem as Food;

            lvAddedMenu.Items.Add(food);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void lbCategory_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    if (lbCategory.SelectedIndex == -1) return;

        //    Category category = (Category)lbCategory.SelectedIndex;
        //    lbMenus.ItemsSource = lstMenu.Where(x => x.category == category).ToList();
        //}
    }
}
