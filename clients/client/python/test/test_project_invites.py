"""
    Ory APIs

    Documentation for all public and administrative Ory APIs. Administrative APIs can only be accessed with a valid Personal Access Token. Public APIs are mostly used in browsers.   # noqa: E501

    The version of the OpenAPI document: v0.0.1-alpha.73
    Contact: support@ory.sh
    Generated by: https://openapi-generator.tech
"""


import sys
import unittest

import ory_client
from ory_client.model.project_invite import ProjectInvite
globals()['ProjectInvite'] = ProjectInvite
from ory_client.model.project_invites import ProjectInvites


class TestProjectInvites(unittest.TestCase):
    """ProjectInvites unit test stubs"""

    def setUp(self):
        pass

    def tearDown(self):
        pass

    def testProjectInvites(self):
        """Test ProjectInvites"""
        # FIXME: construct object with mandatory attributes with example values
        # model = ProjectInvites()  # noqa: E501
        pass


if __name__ == '__main__':
    unittest.main()
