   M S B A M L   `   `   `  ����  WpfApplication1     WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      � .+�5   
   o� -   5         o�Name$
 Menu��5      $
��Left=�6   $��28��68   $	��Top=�6D   $	��517��6\   .@�5      m� -   5         m�Name$
 file��5      $��28��6%   $��53��61   $��Файл��6<   .@�5      m� -   5        $ close��5      $��Закрыть��6>   5	      m� 5
      -   5        $ tasks��5
      $��Задачи��6&   .@�5      m� -   5        $��task1��5      $B��<Нахождение площади треугольника��6<   m� 5      -   5        $��task2��5      $F��@Нахождение периметра треугольника��6<   5      m� 5      -   5        $
 info��5      $��Информация��6%   .@�5      m� -   5        $
 auth��5      $��Об авторе��6<   5      5      	� 5   
   -	   5         	�Name$ rdbttn1��5      $4��.Треугольник по умолчанию��6'   $
��Left=�6J   $	��Top=�6e   $��	23,46,0,0q�6}   6�   	� 5   
   -
   5        $ rdbttn2��5      $E��?Задать треугольник по координатам��6'   $
��Left=�6S   $	��Top=�6n   $��	23,66,0,0q�6�   6�   �� 5   
   -   5         ��Name$ label1��5      $��Сторона А��6    $
��Left=�64   $	��Top=�6O   $��
36,112,0,0q�6g   �� 5   
   -   5        $ label2��5      $��Сторона B��6    $
��Left=�64   $	��Top=�6O   $��
36,143,0,0q�6g   �� 5   
   -   5        $ label3��5      $��Сторона С��6    $
��Left=�64   $	��Top=�6O   $��
36,174,0,0q�6g   �� 5   
   -   5         ��Name$ txtbx1��5      $
��Left=�6"   $��23��6=    �� TextWrapping$
 Wrap=�6I   $	��Top=�6]   $	��120��6u   $��123,116,0,0q�6�   �� 5   
   -   5        $ txtbx2��5      $
��Left=�6"   $��23��6=   $��123,147,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5   
   -   5        $ txtbx3��5      $
��Left=�6"   $��23��6=   $��123,178,0,0q�6I   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 5   
   -   5         ��Name$ bttn1��5      $��Вычисления��6    $
��Left=�65   $	��Top=�6P   $��75��6h   $��
36,267,0,0q�6s   6�   �� 5   
   -   5        $	 ans��5      $�� ��6   $
��Left=�6(   $	��Top=�6C   $��123,264,0,0q�6[   $	��373��6p   �� 5   
   -   5        $ coord��5      $��x1 = ��6   $
��Left=�6/   $	��Top=�6J   $��
325,31,0,0q�6b   �� 5   
   -   5        $ coord1��5      $��y1 = ��6    $
��Left=�60   $	��Top=�6K   $��
325,62,0,0q�6c   �� 5   
   -   5        $ coord2��5      $��x2 = ��6    $
��Left=�60   $	��Top=�6K   $��325,114,0,0q�6c   �� 5   
   -   5        $ coord3��5      $��y2 = ��6    $
��Left=�60   $	��Top=�6K   $��325,145,0,0q�6c   �� 5    
   -   5        $ coord4��5       $��x3 = ��6    $
��Left=�60   $	��Top=�6K   $��325,196,0,0q�6c   �� 5!   
   -   5        $ coord5��5!      $��y3 = ��6    $
��Left=�60   $	��Top=�6K   $��325,227,0,0q�6c   �� 5"   
   -   5        $ 
txtbxCoord��5"      $
��Left=�6&   $��23��6A   $
 Wrap=�6M   $	��Top=�6a   $	��134��6y   $��
362,35,0,0q�6�   �� 5#   
   -   5        $ txtbxCoord1��5#      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��134��6z   $��
362,66,0,0q�6�   �� 5$   
   -   5        $ txtbxCoord2��5$      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��134��6z   $��362,118,0,0q�6�   �� 5%   
   -   5        $ txtbxCoord3��5%      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��134��6z   $��362,149,0,0q�6�   �� 5&   
   -   5        $ txtbxCoord4��5&      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��134��6z   $��362,200,0,0q�6�   �� 5'   
   -   5        $ txtbxCoord5��5'      $
��Left=�6'   $��23��6B   $
 Wrap=�6N   $	��Top=�6b   $	��134��6z   $��362,231,0,0q�6�   	� 5(   
   -   5        $ rdbttn2_Copy��5(      $?��9Задать треугольник по сторонам��6,   $
��Left=�6U   $	��Top=�6p   $��	23,86,0,0q�6�   6�   5*      5+      