from sys import argv
from math import floor

if (len(argv) == 1):
    print("python makeString.py 'Exampe' [box]")
    exit(0)

max_length = 80
title = argv[1].strip()
title = ' ' + title + ' '
title_length = len(title)

is_box = False
if (len(argv) > 2):
    if (argv[2] == 'box'):
        is_box = True

num_pad_start = floor((max_length - title_length) / 2)
num_pad_end = max_length - title_length - num_pad_start

result_string = '-' * num_pad_start + title + '-' * num_pad_end

if is_box:
    result_string = '--' + ' ' * (num_pad_start - 2) + \
        title + ' ' * (num_pad_end - 2) + '--'
    result_string = f"{'-'*80}\n{result_string}\n{'-'*80}"

print(result_string)
