   M S B A M L   `   `   `  ����  
WeatherApp1    +WeatherApp.Views.CheckWeatherForecastWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	     � Title$%  Consultar pronóstico de clima.��5   	   $	��450��60   $	��900��6=   .��5      � ��5	   
   �� 5
       �� ImageSource$/ )/Resources/PinkGrayGradientBackground.jpg��6   .+�5   
   �� -   5         ��Name$ 	NameLabel��5      $��Center=�6#   $��0,20,0,0q�6@   $	��Top=�6R   $	��450��6j   $��Center=�6v   $��Segoe UI Semibold)�6�   $��24(�6�   
�������6�   �� 5   
   
�������$��1q�6%   $��33,90,717,95q�69   �� 5   
   $��Día 1��6   $
��Left=�6    $��	80,90,0,0q�6;   $	��Top=�6N   $��Segoe UI Semilight)�6f   $��14(�6�   
�������6�   �� 5   
   -   5         ��Name$ FirstDayWeatherIcon��5      $
��Left=�6-   $	��100��6H   $��
52,105,0,0q�6U   $	��Top=�6i   $	��100��6�   �� 5   
   -   5        $ FirstDayDescriptionLabel��5      $
��Left=�62   $��
40,200,0,0q�6M   $	��Top=�6a   $��Segoe UI Semilight)�6y   $��14(�6�   
�������$
��Left=�6�   �� 5   
   -   5        $$ FirstDayMiniumTemperatureLabel��5      $��Temp. mínima: ��68   $
��Left=�6Q   $��
40,240,0,0q�6l   $	��Top=�6�   $��Segoe UI Semilight)�6�   
�������$
��Left=�6�   �� 5   
   -   5        $$ FirstDayMaxiumTemperatureLabel��5      $��Temp. máxima: ��68   $
��Left=�6Q   $��
40,270,0,0q�6l   $	��Top=�6�   $��Segoe UI Semilight)�6�   
�������$
��Left=�6�   �� 5   
   
�������$��1q�6%   $��203,90,547,95q�69   �� 5   
   $��Día 2��6   $
��Left=�6    $��
250,90,0,0q�6;   $	��Top=�6O   $��Segoe UI Semilight)�6g   $��14(�6�   
�������6�   �� 5   
   -   5        $ SecondDayWeatherIcon��5      $
��Left=�6.   $	��100��6I   $��222,105,0,0q�6V   $	��Top=�6k   $	��100��6�   �� 5   
   -   5        $ SecondDayDescriptionLabel��5      $
��Left=�63   $��210,200,0,0q�6N   $	��Top=�6c   $��Segoe UI Semilight)�6{   $��14(�6�   
�������$
��Left=�6�   �� 5   
   -   5        $% SecondDayMiniumTemperatureLabel��5      $��Temp. mínima: ��69   $
��Left=�6R   $��210,240,0,0q�6m   $	��Top=�6�   $��Segoe UI Semilight)�6�   
�������$
��Left=�6�   �� 5   
   -	   5        $% SecondDayMaxiumTemperatureLabel��5      $��Temp. máxima: ��69   $
��Left=�6R   $��210,270,0,0q�6m   $	��Top=�6�   $��Segoe UI Semilight)�6�   
�������$
��Left=�6�   �� 5   
   
�������$��1q�6%   $��373,90,377,95q�69   �� 5   
   $��Día 3��6   $
��Left=�6    $��
420,90,0,0q�6;   $	��Top=�6O   $��Segoe UI Semilight)�6g   $��14(�6�   
�������6�   �� 5   
   -
   5        $ ThirdDayWeatherIcon��5      $
��Left=�6-   $	��100��6H   $��392,105,0,0q�6U   $	��Top=�6j   $	��100��6�   �� 5   
   -   5        $ ThirdDayDescriptionLabel��5      $
��Left=�62   $��380,200,0,0q�6M   $	��Top=�6b   $��Segoe UI Semilight)�6z   $��14(�6�   
�������$
��Left=�6�   �� 5   
   -   5        $$ ThirdDayMiniumTemperatureLabel��5      $��Temp. mínima: ��68   $
��Left=�6Q   $��380,240,0,0q�6l   $	��Top=�6�   $��Segoe UI Semilight)�6�   
�������$
��Left=�6�   �� 5   
   -   5        $$ ThirdDayMaxiumTemperatureLabel��5      $��Temp. máxima: ��68   $
��Left=�6Q   $��380,270,0,0q�6l   $	��Top=�6�   $��Segoe UI Semilight)�6�   
�������$
��Left=�6�   �� 5   
   
�������$��1q�6%   $��543,90,207,95q�69   �� 5    
   $��Día 4��6   $
��Left=�6    $��
590,90,0,0q�6;   $	��Top=�6O   $��Segoe UI Semilight)�6g   $��14(�6�   
�������6�   �� 5!   
   -   5        $ FourthDayWeatherIcon��5!      $
��Left=�6.   $	��100��6I   $��562,105,0,0q�6V   $	��Top=�6k   $	��100��6�   �� 5"   
   -   5        $ FourthDayDescriptionLabel��5"      $
��Left=�63   $��550,200,0,0q�6N   $	��Top=�6c   $��Segoe UI Semilight)�6{   $��14(�6�   
�������$
��Left=�6�   �� 5#   
   -   5        $% FourthDayMiniumTemperatureLabel��5#      $��Temp. mínima: ��69   $
��Left=�6R   $��550,240,0,0q�6m   $	��Top=�6�   $��Segoe UI Semilight)�6�   
�������$
��Left=�6�   �� 5$   
   -   5        $% FourthDayMaxiumTemperatureLabel��5$      $��Temp. máxima: ��69   $
��Left=�6R   $��550,270,0,0q�6m   $	��Top=�6�   $��Segoe UI Semilight)�6�   
�������$
��Left=�6�   �� 5%   
   
�������$��1q�6%   $��713,90,37,95q�69   �� 5&   
   $��Día 5��6   $
��Left=�6    $��
760,90,0,0q�6;   $	��Top=�6O   $��Segoe UI Semilight)�6g   $��14(�6�   
�������6�   �� 5'   
   -   5        $ FifthDayWeatherIcon��5'      $
��Left=�6-   $	��100��6H   $��732,105,0,0q�6U   $	��Top=�6j   $	��100��6�   �� 5(   
   -   5        $ FifthDayDescriptionLabel��5(      $
��Left=�62   $��720,200,0,0q�6M   $	��Top=�6b   $��Segoe UI Semilight)�6z   $��14(�6�   
�������$
��Left=�6�   �� 5)   
   -   5        $$ FifthDayMiniumTemperatureLabel��5)      $��Temp. mínima: ��68   $
��Left=�6Q   $��720,240,0,0q�6l   $	��Top=�6�   $��Segoe UI Semilight)�6�   
�������$
��Left=�6�   �� 5*   
   -   5        $$ FifthDayMaxiumTemperatureLabel��5*      $��Temp. máxima: ��68   $
��Left=�6Q   $��720,270,0,0q�6l   $	��Top=�6�   $��Segoe UI Semilight)�6�   
�������$
��Left=�6�   5+      5,      