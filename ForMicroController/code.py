# # SPDX-FileCopyrightText: 2018 Kattni Rembor for Adafruit Industries
# #
# # SPDX-License-Identifier: MIT

# import rotaryio
# import board
# import digitalio
# import usb_hid
# from adafruit_hid.consumer_control import ConsumerControl
# from adafruit_hid.consumer_control_code import ConsumerControlCode

# button = digitalio.DigitalInOut(board.SWITCH)
# button.direction = digitalio.Direction.INPUT
# button.pull = digitalio.Pull.UP

# encoder = rotaryio.IncrementalEncoder(board.ROTA, board.ROTB)

# cc = ConsumerControl(usb_hid.devices)

# button_state = None
# last_position = encoder.position

# while True:
#     current_position = encoder.position
#     position_change = current_position - last_position
#     if position_change > 0:
#         for _ in range(position_change):
#             cc.send(ConsumerControlCode.VOLUME_INCREMENT)
#         print(current_position)
#     elif position_change < 0:
#         for _ in range(-position_change):
#             cc.send(ConsumerControlCode.VOLUME_DECREMENT)
#         print(current_position)
#     last_position = current_position
#     if not button.value and button_state is None:
#         button_state = "pressed"
#     if button.value and button_state == "pressed":
#         print("Button pressed.")
#         cc.send(ConsumerControlCode.PLAY_PAUSE)
#         button_state = None
import rotaryio
import board
import usb_hid
from adafruit_hid.mouse import Mouse

encoder = rotaryio.IncrementalEncoder(board.ROTA, board.ROTB)
mouse = Mouse(usb_hid.devices)

last_position = encoder.position

while True:
    current_position = encoder.position
    position_change = current_position - last_position
    if position_change > 0:
        for _ in range(position_change):
            mouse.move(wheel=1)  # Simulate mouse wheel up
        print(current_position)
    elif position_change < 0:
        for _ in range(-position_change):
            mouse.move(wheel=-1)  # Simulate mouse wheel down
        print(current_position)
    last_position = current_position
