   M S B A M L   `   `   `  ����H  DcontractMaker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:contractMaker.Views.PopUpWindows contractMaker.Views.PopUpWindows  5   	   =    7contractMaker.Views.PopUpWindows.NewContractPopUpWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:contractMaker.Views.PopUpWindows     5   	     � Title$  Window1��5   	   $	��200��6   $	��400��6&   .��5	      � .+�5
   
   �� $��New Contract Name��6   $��24(�6-    �� TextAlignment$ Center=�5      $��0,20,0,0q�5      5      �� 5   
   -   5        $��
titleEntry��5   &   $	��200��5      $��30��6   
���   �$��14(�5   "   ��5   "   �� *mTitle+.��5   #   ��5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   -   �� 6   6sys&clr-namespace:System;assembly=mscorlib     6-    �� 
TargetType" ��6    �� 	Resources 5         CueBannerBrush j� 
AlignmentX j� 
AlignmentY j� Stretch !� Visual��%�   &	        !� 5      $
 Left=�6=   $ Center=�6O   $
 None=�6c    5      �� 5   "   $��Contract Name��6(   
�������6@   5      5       �� Triggers 5      P� 5      	 P� Property	 � ��
 �� Empty P� Value# Z
 62   . �5      ��  �� Property � �� �� Value# [  6;   5       P� 5!      	 � �� 62   Z� . �5"      ��  � ��# [  6;   5#      P� 5$      	 �@J�IsKeyboardFocused$
 True��6?   . �5%      ��  � ��
 �����6;   5&      5(      .��5)      5*      �� 5,   
   -   5        $��createButton��5,      $��20��6%   $��80��61   $��220,110,0,0q�5-      $��Create��5.      51      �� 52   
   -   5        $��cancelButton��52      $��20��6%   $��80��61   $��-220,110,0,0q�53      $��Cancel��54      56      57      58      