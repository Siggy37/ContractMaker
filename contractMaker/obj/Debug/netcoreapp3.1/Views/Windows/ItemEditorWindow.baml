   M S B A M L   `   `   `  ����H  DcontractMaker, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:contractMakercontractMaker  5   	   *    $contractMaker.Views.ItemEditorWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:contractMaker     5   	     � Title$  Contract Maker��5   	   $	��450��6    $	��800��6-    � 	Resources 5	      ��%    5      .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   � -   5        $��Header��5   '   $	��800��6   $��20��6   .+�5      �� -   5        $��	titleText��5      $��Placeholder Title��5      $��20��5      $	��300��5      $��
-450,0,0,0q�5      5      �� 5      $��Total: $��6   $��20��5      $��50��5      $��	200,0,0,0q�5      5      �� 5      -   5        $��totalAmountText��5      $��20��5      $	��200��5      $��	450,0,0,0q�5      ��5      �� *mTotalAmount+5!      5"      �� 5#   
   -   5        $��itemList��5#       $	��330��6    �� SelectedItem$ mSelectedItem��60   $ �� IsSynchronizedWithCurrentItem$
 TrueY�5$      ��5%      �� 5&      .R�5'      � .+�5(      (  "System.Windows.Controls.DatePicker  $	��105��5)   %      SelectedDate 5(   %   �� *mDate+5+      �� 5-      $��
titleEntry��6T   $	��200��6"   $��20,0,0,0q�6.   
���   �$��14(�5/   "   ��5.   "   �� *mTitle+.��50   #   ��51      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 52   =   �� 6"   6sys&clr-namespace:System;assembly=mscorlib     6=    �� 
TargetType" ��6(    �� 	Resources 53   &      CueBannerBrush j� 
AlignmentX	 j� 
AlignmentY
 j� Stretch !� Visual��%�   &	        !� 54   *   $
 Left=�6M   $	 Center=�6_   $

 None=�6s    55   .   �� 56   2   $��Title��68   
�������6H   58   +   59   '    �� Triggers 5:   &   P� 5;   *    P� Property � �� �� Empty P� Value# Z 6B   . �5<   .   ��  �� Property � �� �� Value# [  6K   5=   +   P� 5>   *    � �� 6B   Z� . �5?   .   ��  � ��# [  6K   5@   +   P� 5A   *    �@J�IsKeyboardFocused$
 True��6O   . �5B   .   ��  � ��
 �����6K   5C   +   5E   #   .��5F   -   5G      �� 5I      $	��250��6"   $��20,0,0,0q�6.   
���   �$��14(�5K   "   ��5J   "   �� *mNotes+.��5K   0   ��5L      1&clr-namespace:System;assembly=mscorlibSystem 5M   =   �� 6"   6sys&clr-namespace:System;assembly=mscorlib     6=   " ��6(    5N   &   ��%�   &	        !� 5O   *   $
 Left=�6M   $	 Center=�6_   $

 None=�6s    5P   .   �� 5Q   2   $��Notes��68   
�������6H   5S   +   5T   '    5U   &   P� 5V   *    � ��# Z 6B   . �5W   .   ��  � ��# [  6K   5X   +   P� 5Y   *    � �� 6B   Z� . �5Z   .   ��  � ��# [  6K   5[   +   P� 5\   *    �@J�IsKeyboardFocused$
 True��6O   . �5]   .   ��  � ��
 �����6K   5^   +   5`   #   .��5a   -   5b      �� 5d      $��	amountBox��5e   "   -   5        $	��100��5f   "   $��20,0,0,0q�6.   
���   � �� TextAlignment$ Right=�5h   "   $��14(�5k   "   ��5i   "   �� *	mAmount+.��5k   0   ��5l      1&clr-namespace:System;assembly=mscorlibSystem 5m   =   �� 6"   6sys&clr-namespace:System;assembly=mscorlib     6=   " ��6(    5n   &   ��%�   &	        !� 5o   *   $
 Left=�6M   $	 Center=�6_   $

 None=�6s    5p   .   �� 5q   2   $��$Amount��68   
�������6J   5s   +   5t   '    5u   &   P� 5v   *    � ��# Z 6B   . �5w   .   ��  � ��# [  6K   5x   +   P� 5y   *    � �� 6B   Z� . �5z   .   ��  � ��# [  6K   5{   +   P� 5|   *    �@J�IsKeyboardFocused$
 True��6O   . �5}   .   ��  � ��
 �����6K   5~   +   5�   #   .��5�   -   5�      �� 5�      -   5        $��Delete��5�   !   $��20,0,0,0q�5�   !   5�   !   �� 5�      $��Stretch=�6$   
���   �$��4��6O   5�      5�      5�      � 5�   
   .+�5�      �� -   5         ��Name$ newItemButton��5�      $��New Item��6,   $	��100��5�      $��25��6   $
��Left=�5�      $��
40,20,20,0q�5�      5�      �� 5�      -   5        $ 
saveButton��5�      $
��Save��6)   $	��100��5�      $��25��6!   $��Center=�5�      $��250,20,20,0q�5�      5�      �� 5�      -	   5        $ finishButton��5�      $��Finalize��6+   $	��100��5�      $��25��6   $��Right=�5�      $��
20,20,40,0q�5�      5�      5�      5�      5�      