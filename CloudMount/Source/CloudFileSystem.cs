using System;
using System.Collections.Generic;

namespace CloudMount
{
    public class CloudFileSystem
    {
        private CloudFileSystemNode root;

        public CloudFileSystem()
        {
            string prefix = "cloud://";
            root = new CloudFileSystemNode
            {
                AbsolutePath = prefix,
                Name = prefix,
                Type = CloudFileSystemNodeTypeEnum.ROOT
            };
        }

        // Should only be used externally for inserting buckets onto root
        public void AddChild(CloudFileSystemNode parent, CloudFileSystemNode child)
        {
            if (parent.Children == null)
            {
                parent.Children = new List<CloudFileSystemNode>();
            }

            parent.Children.Add(child);
        }

        // Create file in FS by automatically finding the correct node to place under.
        // If directories do not exist in path to file, create them and manage nodes.
        public void AddFileWithAbsolutePath(string path)
        {
            // TODO
            if (!String.IsNullOrEmpty(path))
            {
                path = RemovePrefix(path);
                var parts = path.Split('/');

                if (parts.Length > 0)
                {
                    var file = parts[parts.Length - 1];
                    // the last element is always the file. remove it from list
                    Array.Resize(ref parts, parts.Length - 1);
               
                    var currentNode = root;
                    var currentPath = root.AbsolutePath;
                    foreach (var part in parts)
                    {
                        currentPath += part;
                        var node = FindNodeAtAbsolutePath(currentPath);
                        if (node != null)
                        {
                            currentNode = node;
                        }
                        else
                        {
                            var newNode = new CloudFileSystemNode
                            {
                                AbsolutePath = currentPath,
                                Name = part,
                                Type = CloudFileSystemNodeTypeEnum.DIRECTORY
                            };
                            if (currentNode.Children == null)
                            {
                                currentNode.Children = new List<CloudFileSystemNode>();
                            }
                            currentNode.Children.Add(newNode);
                            currentNode = newNode;
                        }

                        currentPath += "/";
                    }

                    currentPath += file;
                    if (!FileExists(currentPath))
                    {
                        var newNode = new CloudFileSystemNode
                        {
                            AbsolutePath = currentPath,
                            Name = file,
                            Type = CloudFileSystemNodeTypeEnum.FILE
                        };

                        if (currentNode.Children == null)
                        {
                            currentNode.Children = new List<CloudFileSystemNode>();
                        }
                        currentNode.Children.Add(newNode);
                    }
                }
            }
        }

        public bool DirExists(string path)
        {
            var node = FindNodeAtAbsolutePath(path);
            if (node == null)
            {
                return false;
            }

            if (node.Type != CloudFileSystemNodeTypeEnum.DIRECTORY && node.Type != CloudFileSystemNodeTypeEnum.BUCKET)
            {
                return false;
            }

            return true;
        }

        public bool FileExists(string path)
        {
            var node = FindNodeAtAbsolutePath(path);
            if (node == null)
            {
                return false;
            }

            if (node.Type != CloudFileSystemNodeTypeEnum.FILE)
            {
                return false;
            }

            return true;
        }

        public CloudFileSystemNode FindNodeAtAbsolutePath(string path)
        {
            if (!String.IsNullOrEmpty(path))
            {
                path = RemovePrefix(path);
                if (String.IsNullOrEmpty(path))
                {
                    return root;
                }

                var parts = path.Split('/');
                var currentNode = root;
                foreach (var part in parts)
                {
                    var found = false;
                    if (currentNode.Children != null)
                    {
                        foreach (var child in currentNode.Children)
                        {
                            if (child.Name == part)
                            {
                                currentNode = child;
                                found = true;
                                break;
                            }
                        }
                    }

                    if (!found)
                    {
                        return null;
                    }
                }

                return currentNode;
            }
            
            return null;
        }

        public CloudFileSystemNode GetRootNode()
        {
            return root;
        }

        private string RemovePrefix(string path)
        {
           if (!String.IsNullOrEmpty(path))
            {
                if (path.StartsWith("cloud://"))
                {
                    path = path.Substring(8);
                }
                else if (path.StartsWith("/"))
                {
                    path = path.Substring(1);
                }

                // Remove "/" if at end of path
                if (path.Length > 0 && path.Substring(path.Length - 1) == "/")
                {
                    path.Substring(0, path.Length - 2);
                }
            }

            return path;
        }
    }
}
