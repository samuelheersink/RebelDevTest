Written March 24th. 2019 by Samuel Heersink for the Rebel Developer Test
This is a simple application that enables adding and removing key-value pairs to a collection and permits the exporting of these elements to XML

Some notes on the development process:

Before beginning development, I would want to have a conversation with the UX designer as I can see some differences between the provided UX and the application requirements as described in the user stories. A conversation with the designer to clear up these details would also inform my development by giving some direction to what may be important for future development. For the purpose of this project I tried to stick to the provided layout except where it directly contradicts the user stories.

1. Having a large list box on the left hand size seems to be a waste of space for what is essentially a single-line input box. It also complicates development as an editable list box is much more complex than a single textbox. In this case I made the assumption that there was a purpose to the multiple-line input box that would have been cleared up in person by the designer, and I implemented it.

2. The UX sample suggests a JSON export while the user story specified XML. I went with the user story in this case.

3. The key-value pairs on the left are displayed with the "X=Y" syntax that the inputs are accepted in. I decided not to use this syntax since I believed it was a barrier to legibility and it would have required an additional layer of view over top of the existing data.