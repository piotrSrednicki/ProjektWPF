   M S B A M L   `   `   `  ����  
ProjektWPF    ProjektWPF.RegisterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   [ WMahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null=	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks  5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $	��380��6)    � WindowStyle$
 None=�5	       � 
ResizeMode$ NoResize=�6    � Triggers 5
      :� 5   
    :� RoutedEvent$ Window.Loaded��6   [�5      �� 5      .��5      ��  g� RepeatBehavior$ Forever��6!    g� AutoReverse . .��5      ��  �� 
TargetName$ 
mainBorder��6*    �� TargetProperty$U O(Border.Background).(LinearGradientBrush.GradientStops)[0].(GradientStop.Color)�5      	 �� From$	 DarkBlueX�5      	
 �� To$
 HotPinkX�6-    g� Duration$ 0:0:5D�6:   �� 5      $ 
mainBorder��6)   $U O(Border.Background).(LinearGradientBrush.GradientStops)[1].(GradientStop.Color)�5      $	 HotPinkX�5      $
 
DarkVioletX�6.   $ 0:0:5D�6>   �� 5      $ 
mainBorder��6)   $U O(Border.Background).(LinearGradientBrush.GradientStops)[2].(GradientStop.Color)�5      $	 
DarkVioletX�5      $
 DarkBlueX�61   $ 0:0:5D�6?   5      5      5      .��5      �  � RowDefinitions 5   
   �� 5       �� 5!      .+�5#   
   �� -   5        $��
mainBorder��5#       �� CornerRadius$ 10��6#   $��2��65   ��5$      �� 5%      .��5&      �  � Color$ DarkBlue��6#    � Offset$	 0.0Q�64   � 5'      $ HotPink��6#   $
 0.40Q�63   � 5(      $ 
DarkViolet��6#   $	 1.0Q�66   5)      5+      �� 5-   
   $��0,5,5,0q�6   $��Right=�6'   .+�5.      �� -   5         ��Name$ 
ExitButton��5.      $��40��6B   $��40��6M   $��X��6Y   5/      �� 50   
   $��Center=�6   .+�51      ��  �� Orientation$ 
Horizontal=�6   $��Center=�62   .+�52      �� $��/writing.png��6   $��80��6.   �� 53      $��/cinema.png��6   $��80��6-   55      �� 56      $��Movie Enthusiast Notebook��6   $
��Bold"�69   $��	helvetica)�6K   $��25(�57   	   
�������$��Center=�6+    �� Padding$ 0,20,0,0q�6H   6]   �� 58      $��Register��6   $
��Bold"�6(   $��	helvetica)�6:   $��25(�59   	   
�������$��Center=�6+   $ 0,20,0,0q�6H   6]   5:      �� 5<   
   $��1��6   .+�5>      �� $ 
Horizontal=�6   .+�5?      �� -   5         ��Name$ UsernameTextBox��5?      $��	helvetica)�63   $��Light"�6J   $��Username��6]   $��20(�6m   $
��Left=�6{   
�������
������ $��0q�5@   4   $	��235��6H   $��25��6T   $
��Left=�5A       J� Opacity$	 0.7Q�6*   $��62,0,0,0q�68   6L   .  (MahApps.Metro.IconPacks.PackIconMaterial  5B      E AControlzEx, Version=3.0.2.4, Culture=neutral, PublicKeyToken=null�  �ControlzEx.PackIconBase`1[[MahApps.Metro.IconPacks.PackIconMaterialKind, MahApps.Metro.IconPacks.Material, Version=2.3.0.4, Culture=neutral, PublicKeyToken=null]]   Kind$ Account=�6-   $��Center=�6=   $��Center=�6X   
�������5C   )   5D      �� 5E      $	��250��6   $��2��6!   
�������$	 0.7Q�6?   �� 5G      $ 
Horizontal=�6   $��0,20,0,0q�62   .+�5H      �� -   5        $ PasswordTextBox��5H      $��	helvetica)�63   $��Light"�6J   $��Password��6]   $��20(�6m   $
��Left=�6{   
�������
������ $��0q�5I   4   $	��235��6H   $��25��6T   $
��Left=�5J      $	 0.7Q�6*   $��62,0,0,0q�69   6M     5K      $ TextboxPassword=�6-   $��Center=�6E   $��Center=�6`   
�������5L   )   5M      �� 5N      $	��250��6   $��2��6!   
�������$	 0.7Q�6?   �� 5P      $ 
Horizontal=�6   $��0,20,0,0q�62   .+�5Q      �� -   5        $ EmailTextBox��5Q      $��	helvetica)�60   $��Light"�6G   $��Email��6Z   $��20(�6g   $
��Left=�6u   
�������
������ $��0q�5R   4   $	��235��6H   $��25��6T   $
��Left=�5S      $	 0.7Q�6*   $��62,0,0,0q�69   6M     5T      $ Email=�6-   $��Center=�6;   $��Center=�6V   
�������5U   )   5V      �� 5W      $	��250��6   $��2��6!   
�������$	 0.7Q�6?   �� 5Y      $ 
Horizontal=�6   $��0,15,0,0q�62   .+�5Z      �� -   5        $ LoginButton��5Z      $	��100��6H   $��40��6T   $��Login��6`   $��	57,0,60,0q�6p   �� 5[      -   5        $ RegisterButton��5[      $	��100��6N   $��40��6Z   $��Register��6f   5\      �� 5^      $��0,10,0,0q�6   $��Center=�6,   .+�5_      �� -	   5         ��Name$ AlertTextBlock��5_      $��	helvetica)�64   $
��Bold"�6K   $�� ��6]   $��20(�6e   $��Center=�6s    �� TextAlignment$ Center=�5`      
�������
������ $��25��6L   $	 0.7Q�6X   5a      5b      5c      5d      