   M S B A M L   `   `   `  ����K  GWawa_Touchscreen, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:Wawa_TouchscreenWawa_Touchscreen  5   	   !    Wawa_Touchscreen.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:Wawa_Touchscreen     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      �  � RowDefinitions 5
   
   �� 5      $
��198* �6   �� 5      $
��221* �6   .+�5   
   �� $��
Image1.png��6   $
��Fill=�6$    J� Opacity$	 0.3Q�63    J� OpacityMask
 �   �$��2��6U   �� 5   
   $
��Left=�6   $��54��6-   $��657,166.547,0,0q�69    �� TextWrapping$
 Wrap=�6R   $+��%Evan Cheney
Jason Reilly
Chi Lai Fun ��6f   $	��Top=�6�   $	��135��6�   $��1��6�   �� 5   
   -   5         ��Name$ Items��5      $
��Left=�6!   $	��121��6<   $��
646,30,0,0q�6I   $	��Top=�6]   $	��125��6u   6�   �� 5   
   -   5         ��Name$ Items_Label��5      $��Items Selected
��6%   $
��Left=�6H   $��	646,0,0,0q�6c   $	��Top=�6v   $
��Bold"�6�   $��Arial Black)�6�   ���	#FFB61E1E6�   �� 5   
   $�� ��6   $
��Left=�6   $	��Top=�66   �� 5   
   -   5         ��Name$ confirm��5      $��Confirm��6"   $
��Left=�64   $��622,198,0,0q�6O   $	��Top=�6d   $��75��6|   ���	#FF94E0A0$
��Bold"�6�   $��2��6�   �� 5   
   -   5        $ cancel��5      $��Cancel��6!   $
��Left=�62   $��709,198,0,0q�6M   $	��Top=�6b   $��75��6z   ���	#FFEA8888$��2��6�   �� 5   
   -   5        $ Touch��5      $(��"Touch the Screen to begin odrering��6    $
��Left=�6M   $��
86,118,0,0q�6h   $	��Top=�6|   $	��533��6�   $	��235��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $ 0Q�6�   $��2��6�    5      �� 5      	 �� Color$	 Black��6"   
 �� Opacity$
 0Q�60   ��5      �� 5      $	 Black��6"   $
 0Q�60   ��5      �� 5      $	 	#FF707070��6"   $

 0.01Q�64   ��5      �� 5       $	 Black��6"   $
 0Q�60   z�5"      V� 5#      .~�5$      �� �� 5%      �� 5&       �� Angle$ 0.207Q�6&   T� 5'      5(      5*      �� 5+   
   $(��"Touch the Screen to begin ordering��6   $
��Left=�6=   $��214,98.6,0,0q�6X   $��1��6n   $	��Top=�6{   $
��Bold"�6�   $��20(�6�   5,      5-      