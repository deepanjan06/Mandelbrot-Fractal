# Mandelbrot - Fractal Conversion


### About
This fractal software was initially created by converting a Java applet into a Windows Forms Application.

A fractal is, very simply, a “fractional dimension” essentially it is a shape that has infinite detail. Coast lines are fractal (think about a full scale map and going right down to tracing each pebble and rock along the coast line). The Mandelbrot fractal was discovered by the mathematician Benoit Mandelbrot. Essentially the program feeds x,y values into the Mandelbrot equation and it outputs a value, this value determines a pixel colour on the screen.

### Additional Functionality
  - Fractal zoom
  - Correctly Draws zoom box
  - No flicker or display issues
  - Saves state by copying bitmap to file
  - Allows rezooming after the program has been restarted
  - Interface with menus and save dialogue
  - Ability to change colour palette
  - Colour cycling
  - Animation of a sequence of fractals
  - Full smooth Colour cycling

### Animation between fractal states
 1. Select the checkbox labelled 'Animation: Select multiple states'
 2. In the open file dialog, select the files from the resources folder in the following order: "fractal-animation-state1" "fractal-animation-state2" 

### Animation of a sequence of fractals
 1. Select the checkbox labelled 'Sequence of fractals'
 2. In the open file dialog, select the files from the resources folder in the following order: "fractal-state1" "fractal-state2" "fractal-state3" "fractal-state4"
