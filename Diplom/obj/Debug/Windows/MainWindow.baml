   M S B A M L   `   `   `  ����A  =Diplom, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:DiplomDiplom  5   	       Diplom.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   U QMaterialDesignThemes.Wpf, Version=3.0.1.920, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   :md1http://materialdesigninxaml.net/winfx/xaml/themes  5   	    localclr-namespace:Diplom  5   	   
�������  � Title$]  WСистема регистрации студентов в общежитии ТТИТ��5   
   $	��550��6A   $
��1000��6N    � WindowStartupLocation$ CenterScreen=�6[      Back#��[  6�    � 
ResizeMode$ NoResize=�6�   .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      $	��300 �6   �� 5      $��* �6   .+�5   
   ��  K� ZIndex$	 999��6   $��1��6'   $��Center=�67   $��Center=�6T   $��20(�6o   ��6}   ��  �� ElementName$ frame�� �� Path$ Content.Title� � 5   
   -   5        $��frame��5        � NavigationUIVisibility$ Hidden=�6   $��1��6=   $��1��6M   6\   (  "MaterialDesignThemes.Wpf.ColorZone  5   
   	   Mode$	 
PrimaryMid=�6#   $��2��65   $��51��6I   .��5      � .+�5      '  !MaterialDesignThemes.Wpf.PopupBox  -   5        $��btm_back��5   *   
   PlacementMode$
 BottomAndAlignRightEdges=�6:   $��Right=�6c      ToggleContent 5      �� 5      -   5        $��Btn_Back��5   T     MaterialDesignIconButton#��[ 6!   .��5      '  !MaterialDesignThemes.Wpf.PackIcon  
�������$��14q�6I      Kind$ KeyboardBackspace=�6U   5      5      5       5!      � 5"   
   .+�5#      �� $��46��6   $
��Left=�6   $*��$/Diplom;component/Resources/logo.png��6:   6j   �� 5$      $��13(�6   $��Center=�6&   $��Center=�6A    �� TextAlignment$ Center=�6^   !Томский техникум�� 5%   "   6.   31информационных технологий5&      5'      � 5(   
   $��Stretch=�6   $��1��6-     PrimaryHueMidBrush#��[ 6:   .+�5)      �� $��Stretch=�6   $��Disabled=�69   $
��Auto=�6b   $��1��6�   .��5*      �� -   5         ��Name$
 Menu��5*      $��10q�6+   5+      5,      5-      5.      