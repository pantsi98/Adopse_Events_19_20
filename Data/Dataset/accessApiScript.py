# -*- coding: utf-8 -*-
"""
Created on Thu Nov 21 19:23:42 2019

@author: James
"""
import json
import requests

response = requests.get(
    url="https://api.predicthq.com/v1/events?fields[events]=results",
    headers={
      "Authorization": "Bearer oPZoBwG7_7dQQm7KC_s3MmhqxVu_4805awvIuI8D",
      "Accept": "application/json"
    },
    params={
      "country": "GR"
    }
)

print(response.json())
'''
with open("venues.json","w") as jsonFile:
    json.dump(response.json(),jsonFile)
    
response = requests.get(
    url="https://api.predicthq.com/v1/events",
    headers={
      "Authorization": "Bearer oPZoBwG7_7dQQm7KC_s3MmhqxVu_4805awvIuI8D",
      "Accept": "application/json"
    },
    params={
      "country": "GR"
    }
)

with open("EventsExample.json","w") as jsonFile:
    json.dump(response.json(),jsonFile)
    '''