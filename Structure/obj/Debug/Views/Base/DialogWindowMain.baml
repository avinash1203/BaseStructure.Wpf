   M S B A M L   `   `   `  ����D  @Structure, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:Structure.Views.BaseStructure.Views.Base  5   	   1clr-namespace:Structure.ViewsStructure.Views  5   	   +    %Structure.Views.Base.DialogWindowMain   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:Structure.Views.Base     5   	   /Viewsclr-namespace:Structure.Views     5   	     � WindowStartupLocation$  CenterScreen=�5   :   $
��1000��5   5   $
��1000��6F    � WindowStyle$
 None=�5       � 
ResizeMode$ NoResize=�6-    � SizeToContent$ Manual=�6D    � 	Resources 5
       �� 
TargetType �� Property   CloseButtonClr �� Value �� Triggers	 P� Property
 P� Value  LableClr �� Binding �� RelativeSource �� AncestorType �� Value��%�  'F�       �� 5   
   " F�6   .�5      ��  � ��# �   6'   6R   �� 5       �@��Stretch$ Uniform=�6(   6:   �� 5       � ��$ 3��60   6<    5      P� 5      	 �@J�IsMouseOver
 . . �5      ��  � ��# �  6/   5      �� 5       6   �� *IsMouseOver+ �� $ BorderL� True6s   .a�5      ��  � ��# �  6/   5      5      5      .��5      �� $��5q�6   
������ ._�5   
   �  � RowDefinitions 5      �� 5      $��* �6    $��40��6+   $��20��6:   6L   �� 5      $	��15* �6    6/   �� 5      $��* �6    $��40��6+   $��20��6:   6L   .+�5       � $��0��6   
������ .+�5!      �  � ColumnDefinitions 5"      �� 5#      $
��Auto �6+   6:   �� 5$      $��* �6+   67   �� 5%      $
��Auto �6+   6:   �� 5&      $
��Auto �6+   6:   �� 5'      $
��Auto �6+   6:   .+�5)      �� -   5        $��0��5)   @   $"��Specification - prod HF00004��6P   $
��Bold"�6t   $��Center=�6�   #���   6�   6�   �� 5*      -   5        $��1��5*   ?   
������ $��Stretch=�6b   $��Stretch=�6~   6�   �� 5+      -   5        $��20��5+      $��2��6(   
������ $��0,0,5,0q�6R   ._�5,      F� +����        �@B @B �    @B �@B     	6    5-      �� 5.      -   5        $��20��5.      
������ $��3��6A   $��0,0,5,0q�6�   ._�5/      F� +����        �@B @B �    @B �@B     	6!   50      �� 51      -   5        $��4��51      
������ $��20��6H   $��0,0,5,0q�6   ._�52      F� +����        �@B @B �    @B �@B     	6    53      54      55      � 5:      -   5        $��ContentGrid��5:   5   $y�Visible=�6   $��1��6(   $��Stretch=�6H   $��Stretch=�6d   5<      � 5>      $��2��6   
���  ��5@      5A      5D      5E      